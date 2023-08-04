namespace prjAula1
{
    partial class FormCollection
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
            textBox1 = new TextBox();
            txtNome = new TextBox();
            btnAdicionar = new Button();
            btnListar = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 89);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(521, 23);
            txtNome.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(160, 133);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(98, 35);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(293, 133);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(98, 35);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(521, 214);
            listBox1.TabIndex = 5;
            // 
            // FormCollection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 425);
            Controls.Add(listBox1);
            Controls.Add(btnListar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Name = "FormCollection";
            Text = " Cliente";
            Load += FormCollection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtNome;
        private Button btnAdicionar;
        private Button btnListar;
        private ListBox listBox1;
    }
}