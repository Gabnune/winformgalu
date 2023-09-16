namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgPessoa = new DataGridView();
            label1 = new Label();
            txtId = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            txtSenha = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            btnAdicionar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPessoa).BeginInit();
            SuspendLayout();
            // 
            // dgPessoa
            // 
            dgPessoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPessoa.Location = new Point(12, 275);
            dgPessoa.Name = "dgPessoa";
            dgPessoa.RowTemplate.Height = 25;
            dgPessoa.Size = new Size(597, 126);
            dgPessoa.TabIndex = 0;
            dgPessoa.CellClick += dgPessoa_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 1;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(12, 29);
            txtId.Name = "txtId";
            txtId.Size = new Size(239, 23);
            txtId.TabIndex = 2;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 77);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(239, 23);
            txtNome.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 3;
            label2.Text = "Nome";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(12, 120);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(239, 23);
            txtCpf.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 5;
            label3.Text = "Cpf";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(277, 77);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(239, 23);
            txtSenha.TabIndex = 8;
            txtSenha.TextChanged += txtEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 59);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Senha";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(277, 120);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(239, 23);
            txtEndereco.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 102);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 9;
            label5.Text = "Endereço";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(277, 29);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 23);
            txtEmail.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 11);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 11;
            label6.Text = "Email";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(121, 174);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(238, 174);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(348, 174);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 15;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 429);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(txtEndereco);
            Controls.Add(label5);
            Controls.Add(txtSenha);
            Controls.Add(label4);
            Controls.Add(txtCpf);
            Controls.Add(label3);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(dgPessoa);
            Name = "Form1";
            Text = "Crud de Cliente";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgPessoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgPessoa;
        private Label label1;
        private TextBox txtId;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtSenha;
        private Label label4;
        private TextBox txtEndereco;
        private Label label5;
        private TextBox txtEmail;
        private Label label6;
        private Button btnAdicionar;
        private Button btnEditar;
        private Button btnExcluir;
    }
}