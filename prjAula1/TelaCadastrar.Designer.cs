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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txtCpfCadastro = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtRepetirSenha = new System.Windows.Forms.TextBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.cmbEstados = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Pink;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(195, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 342);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Agency FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.ForeColor = System.Drawing.Color.HotPink;
            this.lblLogin.Location = new System.Drawing.Point(298, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(156, 45);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "CADASTRAR";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNome.Location = new System.Drawing.Point(264, 116);
            this.txtNome.Name = "txtNome";
            this.txtNome.PlaceholderText = "Nome Completo";
            this.txtNome.Size = new System.Drawing.Size(217, 33);
            this.txtNome.TabIndex = 17;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenhaCadastro.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSenhaCadastro.Location = new System.Drawing.Point(264, 194);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.PlaceholderText = "Senha(6 digitos)";
            this.txtSenhaCadastro.Size = new System.Drawing.Size(217, 33);
            this.txtSenhaCadastro.TabIndex = 19;
            // 
            // txtCpfCadastro
            // 
            this.txtCpfCadastro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpfCadastro.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCpfCadastro.Location = new System.Drawing.Point(264, 155);
            this.txtCpfCadastro.Name = "txtCpfCadastro";
            this.txtCpfCadastro.PlaceholderText = "CPF";
            this.txtCpfCadastro.Size = new System.Drawing.Size(217, 33);
            this.txtCpfCadastro.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEmail.Location = new System.Drawing.Point(264, 311);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "email";
            this.txtEmail.Size = new System.Drawing.Size(217, 33);
            this.txtEmail.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DeepPink;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(298, 444);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 36);
            this.button2.TabIndex = 30;
            this.button2.Text = "Criar Conta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(536, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCidade.Location = new System.Drawing.Point(264, 389);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.PlaceholderText = "cidade";
            this.txtCidade.Size = new System.Drawing.Size(217, 33);
            this.txtCidade.TabIndex = 40;
            // 
            // txtRepetirSenha
            // 
            this.txtRepetirSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRepetirSenha.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRepetirSenha.Location = new System.Drawing.Point(264, 233);
            this.txtRepetirSenha.Name = "txtRepetirSenha";
            this.txtRepetirSenha.PlaceholderText = "Repetir senha(6 digitos)";
            this.txtRepetirSenha.Size = new System.Drawing.Size(217, 33);
            this.txtRepetirSenha.TabIndex = 41;
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDataNascimento.Location = new System.Drawing.Point(264, 272);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(217, 33);
            this.dtpDataNascimento.TabIndex = 42;
            // 
            // cmbEstados
            // 
            this.cmbEstados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbEstados.FormattingEnabled = true;
            this.cmbEstados.Location = new System.Drawing.Point(264, 350);
            this.cmbEstados.Name = "cmbEstados";
            this.cmbEstados.Size = new System.Drawing.Size(217, 33);
            this.cmbEstados.TabIndex = 43;
            this.cmbEstados.Text = "UF";
            // 
            // TelaCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(725, 516);
            this.Controls.Add(this.cmbEstados);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.txtRepetirSenha);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCpfCadastro);
            this.Controls.Add(this.txtSenhaCadastro);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TelaCadastrar";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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