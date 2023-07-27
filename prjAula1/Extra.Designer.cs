namespace prjAula1
{
    partial class Extra
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
            valorDeposito = new TextBox();
            btnDepositar = new Button();
            SuspendLayout();
            // 
            // valorDeposito
            // 
            valorDeposito.Location = new Point(12, 12);
            valorDeposito.Name = "valorDeposito";
            valorDeposito.Size = new Size(174, 23);
            valorDeposito.TabIndex = 0;
            valorDeposito.TextChanged += textBox1_TextChanged;
            // 
            // btnDepositar
            // 
            btnDepositar.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnDepositar.Location = new Point(12, 77);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(174, 36);
            btnDepositar.TabIndex = 1;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // Extra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 132);
            Controls.Add(btnDepositar);
            Controls.Add(valorDeposito);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Extra";
            Text = "Extra";
            Load += Extra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox valorDeposito;
        private Button btnDepositar;
    }
}