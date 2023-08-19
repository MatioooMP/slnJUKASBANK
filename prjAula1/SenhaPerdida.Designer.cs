namespace prjAula1
{
    partial class SenhaPerdida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenhaPerdida));
            txtNovaSenha = new TextBox();
            txtCPF = new TextBox();
            txtConfirmarSenha = new TextBox();
            lblCPF = new Label();
            lblNovaSenha = new Label();
            lblConfirmarSenha = new Label();
            pictureBox3 = new PictureBox();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtNovaSenha
            // 
            txtNovaSenha.Location = new Point(103, 207);
            txtNovaSenha.Name = "txtNovaSenha";
            txtNovaSenha.Size = new Size(167, 23);
            txtNovaSenha.TabIndex = 1;
            txtNovaSenha.TextChanged += textBox1_TextChanged;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(103, 167);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(167, 23);
            txtCPF.TabIndex = 1;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Location = new Point(103, 248);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.Size = new Size(167, 23);
            txtConfirmarSenha.TabIndex = 3;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.BackColor = Color.Transparent;
            lblCPF.Location = new Point(66, 175);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 4;
            lblCPF.Text = "CPF:";
            // 
            // lblNovaSenha
            // 
            lblNovaSenha.AutoSize = true;
            lblNovaSenha.BackColor = Color.Transparent;
            lblNovaSenha.Location = new Point(25, 215);
            lblNovaSenha.Name = "lblNovaSenha";
            lblNovaSenha.Size = new Size(72, 15);
            lblNovaSenha.TabIndex = 6;
            lblNovaSenha.Text = "Nova senha:";
            // 
            // lblConfirmarSenha
            // 
            lblConfirmarSenha.AutoSize = true;
            lblConfirmarSenha.BackColor = Color.Transparent;
            lblConfirmarSenha.Location = new Point(-1, 256);
            lblConfirmarSenha.Name = "lblConfirmarSenha";
            lblConfirmarSenha.Size = new Size(98, 15);
            lblConfirmarSenha.TabIndex = 8;
            lblConfirmarSenha.Text = "Confirmar senha:";
            lblConfirmarSenha.Click += label3_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(76, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(194, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 39;
            pictureBox3.TabStop = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.LavenderBlush;
            btnConfirmar.ForeColor = Color.HotPink;
            btnConfirmar.Location = new Point(172, 292);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(98, 31);
            btnConfirmar.TabIndex = 40;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // SenhaPerdida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(320, 348);
            Controls.Add(btnConfirmar);
            Controls.Add(pictureBox3);
            Controls.Add(lblConfirmarSenha);
            Controls.Add(lblNovaSenha);
            Controls.Add(lblCPF);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(txtCPF);
            Controls.Add(txtNovaSenha);
            Name = "SenhaPerdida";
            Text = "SenhaPerdida";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNovaSenha;
        private TextBox txtCPF;
        private TextBox txtConfirmarSenha;
        private Label lblCPF;
        private Label lblNovaSenha;
        private Label lblConfirmarSenha;
        internal protected PictureBox pictureBox3;
        private Button btnConfirmar;
    }
}