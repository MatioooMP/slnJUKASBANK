namespace prjAula1
{
    partial class TelaConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaConta));
            txtSaldoConta = new TextBox();
            txtSenhaConta = new TextBox();
            txtConfirmarSenha = new TextBox();
            lblSaldo = new Label();
            lblSenha = new Label();
            lblConfirmarSenha = new Label();
            btnCriarConta = new Button();
            SuspendLayout();
            // 
            // txtSaldoConta
            // 
            txtSaldoConta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldoConta.Location = new Point(214, 53);
            txtSaldoConta.Name = "txtSaldoConta";
            txtSaldoConta.PlaceholderText = "Saldo";
            txtSaldoConta.Size = new Size(159, 32);
            txtSaldoConta.TabIndex = 0;
            // 
            // txtSenhaConta
            // 
            txtSenhaConta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaConta.Location = new Point(214, 122);
            txtSenhaConta.Name = "txtSenhaConta";
            txtSenhaConta.PlaceholderText = "Senha(6 Digítos)";
            txtSenhaConta.Size = new Size(159, 32);
            txtSenhaConta.TabIndex = 1;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenha.Location = new Point(214, 198);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            txtConfirmarSenha.Size = new Size(159, 32);
            txtConfirmarSenha.TabIndex = 2;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = Color.Transparent;
            lblSaldo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.HotPink;
            lblSaldo.Location = new Point(16, 53);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(192, 25);
            lblSaldo.TabIndex = 3;
            lblSaldo.Text = "Saldo para Depositar:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Transparent;
            lblSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSenha.ForeColor = Color.HotPink;
            lblSenha.Location = new Point(131, 122);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(68, 25);
            lblSenha.TabIndex = 4;
            lblSenha.Text = "Senha:";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.BackColor = Color.Transparent;
            lblConfirmarSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblConfirmarSenha.ForeColor = Color.HotPink;
            lblConfirmarSenha.Location = new Point(50, 198);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(158, 25);
            lblConfirmarSenha.TabIndex = 5;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // btnCriarConta
            // 
            btnCriarConta.Location = new Point(214, 253);
            btnCriarConta.Name = "btnCriarConta";
            btnCriarConta.Size = new Size(159, 37);
            btnCriarConta.TabIndex = 6;
            btnCriarConta.Text = "Criar Conta";
            btnCriarConta.UseVisualStyleBackColor = true;
            btnCriarConta.Click += btnCriarConta_Click;
            // 
            // TelaConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(394, 302);
            Controls.Add(btnCriarConta);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblSaldo);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtSenhaConta);
            Controls.Add(txtSaldoConta);
            Name = "TelaConta";
            Text = "TelaConta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSaldoConta;
        private TextBox txtSenhaConta;
        private TextBox txtConfirmarSenha;
        private Label lblSaldo;
        private Label lblSenha;
        private Label lblConfirmarSenha;
        private Button btnCriarConta;
    }
}