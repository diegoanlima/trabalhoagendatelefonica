namespace AgendaTelefonica
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nome = new System.Windows.Forms.Label();
            this.ContatosListBox = new System.Windows.Forms.ListBox();
            this.LimparBuscaButton = new System.Windows.Forms.Button();
            this.ExcluirContatoButton = new System.Windows.Forms.Button();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.TipoContatoComboBox = new System.Windows.Forms.ComboBox();
            this.AdicionarContatoButton = new System.Windows.Forms.Button();
            this.PesquisarTextBox = new System.Windows.Forms.TextBox();
            this.PesquisarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.ForeColor = System.Drawing.SystemColors.Control;
            this.nome.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.nome.Location = new System.Drawing.Point(29, 30);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(38, 13);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome;";
            // 
            // ContatosListBox
            // 
            this.ContatosListBox.FormattingEnabled = true;
            this.ContatosListBox.Location = new System.Drawing.Point(12, 240);
            this.ContatosListBox.Name = "ContatosListBox";
            this.ContatosListBox.Size = new System.Drawing.Size(776, 199);
            this.ContatosListBox.TabIndex = 1;
            this.ContatosListBox.SelectedIndexChanged += new System.EventHandler(this.ContatosListBox_SelectedIndexChanged);
            // 
            // LimparBuscaButton
            // 
            this.LimparBuscaButton.Location = new System.Drawing.Point(368, 209);
            this.LimparBuscaButton.Name = "LimparBuscaButton";
            this.LimparBuscaButton.Size = new System.Drawing.Size(106, 25);
            this.LimparBuscaButton.TabIndex = 3;
            this.LimparBuscaButton.Text = "Limpar Busca";
            this.LimparBuscaButton.UseVisualStyleBackColor = true;
            this.LimparBuscaButton.Click += new System.EventHandler(this.LimparBuscaButton_Click);
            // 
            // ExcluirContatoButton
            // 
            this.ExcluirContatoButton.Location = new System.Drawing.Point(242, 135);
            this.ExcluirContatoButton.Name = "ExcluirContatoButton";
            this.ExcluirContatoButton.Size = new System.Drawing.Size(68, 23);
            this.ExcluirContatoButton.TabIndex = 4;
            this.ExcluirContatoButton.Text = "Excluir";
            this.ExcluirContatoButton.UseVisualStyleBackColor = true;
            this.ExcluirContatoButton.Click += new System.EventHandler(this.ExcluirContatoButton_Click_1);
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(118, 27);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.NomeTextBox.TabIndex = 5;
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Location = new System.Drawing.Point(118, 53);
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.TelefoneTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label1.Location = new System.Drawing.Point(29, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numero:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(118, 79);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmailTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "EMAIL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de Contato:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(480, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // TipoContatoComboBox
            // 
            this.TipoContatoComboBox.FormattingEnabled = true;
            this.TipoContatoComboBox.Items.AddRange(new object[] {
            "Celular",
            "Residencial",
            "Comercial"});
            this.TipoContatoComboBox.Location = new System.Drawing.Point(118, 105);
            this.TipoContatoComboBox.Name = "TipoContatoComboBox";
            this.TipoContatoComboBox.Size = new System.Drawing.Size(100, 21);
            this.TipoContatoComboBox.TabIndex = 13;
            // 
            // AdicionarContatoButton
            // 
            this.AdicionarContatoButton.Location = new System.Drawing.Point(161, 135);
            this.AdicionarContatoButton.Name = "AdicionarContatoButton";
            this.AdicionarContatoButton.Size = new System.Drawing.Size(75, 23);
            this.AdicionarContatoButton.TabIndex = 14;
            this.AdicionarContatoButton.Text = "Salvar";
            this.AdicionarContatoButton.UseVisualStyleBackColor = true;
            this.AdicionarContatoButton.Click += new System.EventHandler(this.AdicionarContatoButton_Click_1);
            // 
            // PesquisarTextBox
            // 
            this.PesquisarTextBox.Location = new System.Drawing.Point(480, 209);
            this.PesquisarTextBox.Name = "PesquisarTextBox";
            this.PesquisarTextBox.Size = new System.Drawing.Size(200, 20);
            this.PesquisarTextBox.TabIndex = 15;
            // 
            // PesquisarButton
            // 
            this.PesquisarButton.Location = new System.Drawing.Point(698, 207);
            this.PesquisarButton.Name = "PesquisarButton";
            this.PesquisarButton.Size = new System.Drawing.Size(75, 23);
            this.PesquisarButton.TabIndex = 16;
            this.PesquisarButton.Text = "Buscar";
            this.PesquisarButton.UseVisualStyleBackColor = true;
            this.PesquisarButton.Click += new System.EventHandler(this.PesquisarButton_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(808, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PesquisarButton);
            this.Controls.Add(this.PesquisarTextBox);
            this.Controls.Add(this.AdicionarContatoButton);
            this.Controls.Add(this.TipoContatoComboBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TelefoneTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeTextBox);
            this.Controls.Add(this.ExcluirContatoButton);
            this.Controls.Add(this.LimparBuscaButton);
            this.Controls.Add(this.ContatosListBox);
            this.Controls.Add(this.nome);
            this.Name = "MainForm";
            this.Text = "Agenda ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.ListBox ContatosListBox;
        private System.Windows.Forms.Button LimparBuscaButton;
        private System.Windows.Forms.Button ExcluirContatoButton;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.TextBox TelefoneTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox TipoContatoComboBox;
        private System.Windows.Forms.Button AdicionarContatoButton;
        private System.Windows.Forms.TextBox PesquisarTextBox;
        private System.Windows.Forms.Button PesquisarButton;
        private System.Windows.Forms.Button button1;
    }
}

