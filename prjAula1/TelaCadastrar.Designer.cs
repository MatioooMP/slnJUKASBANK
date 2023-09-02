namespace prjAula1
{
    partial class TelaCadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastrar));
            pictureBox1 = new PictureBox();
            lblLogin = new Label();
            txtNome = new TextBox();
            txtSenhaCadastro = new TextBox();
            txtCpfCadastro = new TextBox();
            txtEmail = new TextBox();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            txtCidade = new TextBox();
            txtRepetirSenha = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            cmbEstados = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Pink;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(195, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 342);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Agency FB", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = Color.HotPink;
            lblLogin.Location = new Point(298, 32);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(156, 45);
            lblLogin.TabIndex = 16;
            lblLogin.Text = "CADASTRAR";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.ForeColor = SystemColors.ScrollBar;
            txtNome.Location = new Point(264, 116);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(217, 33);
            txtNome.TabIndex = 17;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaCadastro.ForeColor = SystemColors.ScrollBar;
            txtSenhaCadastro.Location = new Point(264, 194);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PlaceholderText = "Senha(6 digitos)";
            txtSenhaCadastro.Size = new Size(217, 33);
            txtSenhaCadastro.TabIndex = 19;
            // 
            // txtCpfCadastro
            // 
            txtCpfCadastro.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCadastro.ForeColor = SystemColors.ScrollBar;
            txtCpfCadastro.Location = new Point(264, 155);
            txtCpfCadastro.Name = "txtCpfCadastro";
            txtCpfCadastro.PlaceholderText = "CPF";
            txtCpfCadastro.Size = new Size(217, 33);
            txtCpfCadastro.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = SystemColors.ScrollBar;
            txtEmail.Location = new Point(264, 311);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "email";
            txtEmail.Size = new Size(217, 33);
            txtEmail.TabIndex = 24;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepPink;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(298, 444);
            button2.Name = "button2";
            button2.Size = new Size(156, 36);
            button2.TabIndex = 30;
            button2.Text = "Criar Conta";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(536, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(177, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 38;
            pictureBox2.TabStop = false;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.ForeColor = SystemColors.ScrollBar;
            txtCidade.Location = new Point(264, 389);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "cidade";
            txtCidade.Size = new Size(217, 33);
            txtCidade.TabIndex = 40;
            // 
            // txtRepetirSenha
            // 
            txtRepetirSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepetirSenha.ForeColor = SystemColors.ScrollBar;
            txtRepetirSenha.Location = new Point(264, 233);
            txtRepetirSenha.Name = "txtRepetirSenha";
            txtRepetirSenha.PlaceholderText = "Repetir senha(6 digitos)";
            txtRepetirSenha.Size = new Size(217, 33);
            txtRepetirSenha.TabIndex = 41;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDataNascimento.Location = new Point(264, 272);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(217, 33);
            dtpDataNascimento.TabIndex = 42;
            // 
            // cmbEstados
            // 
            cmbEstados.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbEstados.FormattingEnabled = true;
            cmbEstados.Location = new Point(264, 350);
            cmbEstados.Name = "cmbEstados";
            cmbEstados.Size = new Size(217, 33);
            cmbEstados.TabIndex = 43;
            cmbEstados.Text = "UF";
            // 
            // TelaCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(725, 516);
            Controls.Add(cmbEstados);
            Controls.Add(dtpDataNascimento);
            Controls.Add(txtRepetirSenha);
            Controls.Add(txtCidade);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(txtEmail);
            Controls.Add(txtCpfCadastro);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(txtNome);
            Controls.Add(lblLogin);
            Controls.Add(pictureBox1);
            Name = "TelaCadastrar";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblLogin;
        private TextBox txtNome;
        private TextBox txtSenhaCadastro;
        private TextBox txtCpfCadastro;
        private TextBox txtEmail;
        private Button button2;
        internal protected PictureBox pictureBox2;
        private TextBox txtCidade;
        private TextBox txtRepetirSenha;
        private DateTimePicker dtpDataNascimento;
        private ComboBox cmbEstados;
    }
}