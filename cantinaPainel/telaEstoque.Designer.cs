namespace cantinaPainel
{
    partial class formsEstoque
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
            listBoxEstoque = new ListBox();
            btnAdicionar = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // listBoxEstoque
            // 
            listBoxEstoque.FormattingEnabled = true;
            listBoxEstoque.ItemHeight = 15;
            listBoxEstoque.Location = new Point(108, 47);
            listBoxEstoque.Name = "listBoxEstoque";
            listBoxEstoque.Size = new Size(374, 379);
            listBoxEstoque.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(567, 128);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(97, 30);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar ⚡";
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(567, 181);
            button2.Name = "button2";
            button2.Size = new Size(97, 27);
            button2.TabIndex = 2;
            button2.Text = "⬅ Remover";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(567, 244);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(97, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // formsEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(btnAdicionar);
            Controls.Add(listBoxEstoque);
            Name = "formsEstoque";
            Text = "telaEstoque";
            Load += telaEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEstoque;
        private Button btnAdicionar;
        private Button button2;
        private NumericUpDown numericUpDown1;
    }
}