﻿namespace prjAula1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnDepositar = new Button();
            txtSaldoDepositar = new TextBox();
            lblSaldoDepositar = new Label();
            txtSenhaConfirmar = new TextBox();
            lblConfirmarSenha = new Label();
            SuspendLayout();
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(159, 174);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(100, 23);
            btnDepositar.TabIndex = 0;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // txtSaldoDepositar
            // 
            txtSaldoDepositar.Location = new Point(159, 80);
            txtSaldoDepositar.Name = "txtSaldoDepositar";
            txtSaldoDepositar.Size = new Size(100, 23);
            txtSaldoDepositar.TabIndex = 1;
            // 
            // lblSaldoDepositar
            // 
            lblSaldoDepositar.AutoSize = true;
            lblSaldoDepositar.Location = new Point(35, 83);
            lblSaldoDepositar.Name = "lblSaldoDepositar";
            lblSaldoDepositar.Size = new Size(118, 15);
            lblSaldoDepositar.TabIndex = 2;
            lblSaldoDepositar.Text = "Saldo para Depositar:";
            // 
            // txtSenhaConfirmar
            // 
            txtSenhaConfirmar.Location = new Point(159, 124);
            txtSenhaConfirmar.Name = "txtSenhaConfirmar";
            txtSenhaConfirmar.Size = new Size(100, 23);
            txtSenhaConfirmar.TabIndex = 3;
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.Location = new Point(54, 132);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(99, 15);
            lblConfirmarSenha.TabIndex = 4;
            lblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(391, 248);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(txtSenhaConfirmar);
            Controls.Add(lblSaldoDepositar);
            Controls.Add(txtSaldoDepositar);
            Controls.Add(btnDepositar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDepositar;
        private TextBox txtSaldoDepositar;
        private Label lblSaldoDepositar;
        private TextBox txtSenhaConfirmar;
        private Label lblConfirmarSenha;
    }
}