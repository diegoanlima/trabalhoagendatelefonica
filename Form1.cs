using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class MainForm : Form
    {
        private List<Contato> contatos;

        public MainForm()
        {
            InitializeComponent();
            contatos = new List<Contato>();

            // Vincule o evento Load do formulário ao método MainForm_Load
            this.Load += MainForm_Load;
        }

       
        private void PesquisarButton_Click(object sender, EventArgs e)
        {
            string termoPesquisa = PesquisarTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(termoPesquisa))
            {
                var contatosFiltrados = contatos.Where(contato =>
                    contato.Nome.IndexOf(termoPesquisa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    contato.Telefone.IndexOf(termoPesquisa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    contato.Email.IndexOf(termoPesquisa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    contato.Tipo.IndexOf(termoPesquisa, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();

                AtualizarListBox(contatosFiltrados);
            }
            else
            {
                AtualizarListBox();
            }
        }

        private void ContatosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContatosListBox.SelectedItem != null)
            {
                // Obter o contato selecionado
                Contato contatoSelecionado = (Contato)ContatosListBox.SelectedItem;

                // Exibir os detalhes do contato selecionado nos TextBoxes
                NomeTextBox.Text = contatoSelecionado.Nome;
                TelefoneTextBox.Text = contatoSelecionado.Telefone;
                EmailTextBox.Text = contatoSelecionado.Email;
                TipoContatoComboBox.SelectedItem = contatoSelecionado.Tipo;
            }
            else
            {
                // Se nenhum contato estiver selecionado, limpar os TextBoxes
                LimparCampos();
            }
        }

        private void AtualizarListBox(List<Contato> contatosParaExibir = null)
        {
            ContatosListBox.Items.Clear();
            if (contatosParaExibir == null)
            {
                foreach (Contato contato in contatos)
                {
                    ContatosListBox.Items.Add(contato);
                }
            }
            else
            {
                foreach (Contato contato in contatosParaExibir)
                {
                    ContatosListBox.Items.Add(contato);
                }
            }
        }

        private void LimparCampos()
        {
            NomeTextBox.Clear();
            TelefoneTextBox.Clear();
            EmailTextBox.Clear();
            TipoContatoComboBox.SelectedIndex = -1;
        }

        // Método para carregar contatos quando o formulário é carregado
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Carregar contatos do armazenamento
            contatos = CarregarContatosDoArmazenamento();

            // Atualizar a lista de contatos
            AtualizarListBox();
        }

        // Método para salvar os contatos no armazenamento permanente
        private void SalvarContatosNoArmazenamento()
        {
            // Converte cada contato para uma string formatada para salvar no arquivo
            List<string> linhas = contatos.Select(contato => $"{contato.Nome},{contato.Telefone},{contato.Email},{contato.Tipo}").ToList();

            // Salva as linhas no arquivo de texto
            File.WriteAllLines("contatos.txt", linhas);
        }

        // Método para carregar contatos do armazenamento permanente
        private List<Contato> CarregarContatosDoArmazenamento()
        {
            List<Contato> contatosCarregados = new List<Contato>();

            // Verifica se o arquivo de contatos existe
            if (File.Exists("contatos.txt"))
            {
                // Carrega todas as linhas do arquivo
                string[] linhas = File.ReadAllLines("contatos.txt");

                // Para cada linha, divide os valores pelo separador ',' e cria um novo contato
                foreach (string linha in linhas)
                {
                    string[] valores = linha.Split(',');
                    if (valores.Length == 4)
                    {
                        Contato contato = new Contato(valores[0], valores[1], valores[2], valores[3]);
                        contatosCarregados.Add(contato);
                    }
                }
            }

            return contatosCarregados;
        }

        private void AdicionarContatoButton_Click_1(object sender, EventArgs e)
        {
            // Obter dados do formulário
            string nome = NomeTextBox.Text.Trim();
            string telefone = TelefoneTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string tipo = TipoContatoComboBox.SelectedItem?.ToString();

            // Verificar se todos os campos foram preenchidos
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(telefone) && !string.IsNullOrEmpty(tipo))
            {
                // Criar um novo objeto Contato
                Contato novoContato = new Contato(nome, telefone, email, tipo);

                // Adicionar o novo contato à lista
                contatos.Add(novoContato);

                // Atualizar o ListBox
                AtualizarListBox();

                // Salvar contatos no armazenamento
                SalvarContatosNoArmazenamento();

                // Limpar os campos do formulário
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }

     

        private void ExcluirContatoButton_Click_1(object sender, EventArgs e)
        {
            
                if (ContatosListBox.SelectedItem != null)
                {
                    // Obtém o contato selecionado
                    Contato contatoSelecionado = (Contato)ContatosListBox.SelectedItem;

                    // Remove o contato da lista
                    contatos.Remove(contatoSelecionado);

                    // Atualiza o ListBox
                    AtualizarListBox();

                    // Salva contatos no armazenamento
                    SalvarContatosNoArmazenamento();

                    // Limpa os campos do formulário
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, selecione um contato para excluir.");
                }
            }

        

        private void EditarContatoButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }

        public Contato(string nome, string telefone, string email, string tipo)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Tipo = tipo;
        }

        public override string ToString()
        {
            return $"{Nome} - {Telefone} - {Email} - {Tipo}";
        }
    }
}
