namespace prjAula1
{
    partial class TelaSaque
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
            lblConfirmarSenha = new Label();
            txtSenhaConfirmar = new TextBox();
            lblSaldoSacar = new Label();
            txtSaldoSacar = new TextBox();
            btnSaque = new Button();
            lblSaldo = new Label();
            lblSaldoAtual = new Label();
            SuspendLayout();
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(24, 121);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(99, 15);
            lblConfirmarSenha.TabIndex = 9;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // txtSenhaConfirmar
            // 
            txtSenhaConfirmar.Location = new Point(129, 113);
            txtSenhaConfirmar.Name = "txtSenhaConfirmar";
            txtSenhaConfirmar.Size = new Size(100, 23);
            txtSenhaConfirmar.TabIndex = 8;
            // 
            // lblSaldoSacar
            // 
            lblSaldoSacar.AutoSize = true;
            lblSaldoSacar.Location = new Point(27, 77);
            lblSaldoSacar.Name = "lblSaldoSacar";
            lblSaldoSacar.Size = new Size(96, 15);
            lblSaldoSacar.TabIndex = 7;
            lblSaldoSacar.Text = "Saldo para Sacar:";
            // 
            // txtSaldoSacar
            // 
            txtSaldoSacar.Location = new Point(129, 69);
            txtSaldoSacar.Name = "txtSaldoSacar";
            txtSaldoSacar.Size = new Size(100, 23);
            txtSaldoSacar.TabIndex = 6;
            // 
            // btnSaque
            // 
            btnSaque.Location = new Point(129, 163);
            btnSaque.Name = "btnSaque";
            btnSaque.Size = new Size(100, 23);
            btnSaque.TabIndex = 5;
            btnSaque.Text = "Sacar";
            btnSaque.UseVisualStyleBackColor = true;
            btnSaque.Click += btnDepositar_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(27, 26);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(39, 15);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoAtual
            // 
            lblSaldoAtual.AutoSize = true;
            lblSaldoAtual.Location = new Point(72, 26);
            lblSaldoAtual.Name = "lblSaldoAtual";
            lblSaldoAtual.Size = new Size(0, 15);
            lblSaldoAtual.TabIndex = 11;
            // 
            // TelaSaque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 204);
            Controls.Add(lblSaldoAtual);
            Controls.Add(lblSaldo);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtSenhaConfirmar);
            Controls.Add(lblSaldoSacar);
            Controls.Add(txtSaldoSacar);
            Controls.Add(btnSaque);
            Name = "TelaSaque";
            Text = "TelaSaque";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmarSenha;
        private TextBox txtSenhaConfirmar;
        private Label lblSaldoSacar;
        private TextBox txtSaldoSacar;
        private Button btnSaque;
        private Label lblSaldo;
        private Label lblSaldoAtual;
    }
}