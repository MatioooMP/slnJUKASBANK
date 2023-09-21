namespace prjAula1
{
    partial class TelaAlterarConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAlterarConta));
            cmbIdConta = new ComboBox();
            txtConfirmarSenha = new TextBox();
            btnAlterarDados = new Button();
            SuspendLayout();
            // 
            // cmbIdConta
            // 
            cmbIdConta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbIdConta.FormattingEnabled = true;
            cmbIdConta.Location = new Point(61, 122);
            cmbIdConta.Name = "cmbIdConta";
            cmbIdConta.Size = new Size(159, 33);
            cmbIdConta.TabIndex = 19;
            // 
            // txtConfirmarSenha
            // 
            txtConfirmarSenha.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmarSenha.Location = new Point(61, 182);
            txtConfirmarSenha.Name = "txtConfirmarSenha";
            txtConfirmarSenha.PlaceholderText = "Confirmar Senha";
            txtConfirmarSenha.Size = new Size(159, 32);
            txtConfirmarSenha.TabIndex = 20;
            // 
            // btnAlterarDados
            // 
            btnAlterarDados.BackColor = Color.DeepPink;
            btnAlterarDados.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAlterarDados.ForeColor = Color.White;
            btnAlterarDados.Location = new Point(61, 246);
            btnAlterarDados.Name = "btnAlterarDados";
            btnAlterarDados.Size = new Size(159, 40);
            btnAlterarDados.TabIndex = 51;
            btnAlterarDados.Text = "Alterar Dados";
            btnAlterarDados.UseVisualStyleBackColor = false;
            btnAlterarDados.Click += btnAlterarDados_Click;
            // 
            // TelaAlterarConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(279, 325);
            Controls.Add(btnAlterarDados);
            Controls.Add(txtConfirmarSenha);
            Controls.Add(cmbIdConta);
            Name = "TelaAlterarConta";
            Text = "TelaAlterarConta";
            Load += TelaAlterarConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbIdConta;
        private TextBox txtConfirmarSenha;
        private Button btnAlterarDados;
    }
}