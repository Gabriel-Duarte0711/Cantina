namespace cantinaPainel
{
    partial class formsAdm
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
            label1 = new Label();
            txtBoxAddProduto = new TextBox();
            txtBoxAddPreco = new TextBox();
            label2 = new Label();
            btnAdicionar = new Button();
            listBoxTest = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 72);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Produto";
            // 
            // txtBoxAddProduto
            // 
            txtBoxAddProduto.Location = new Point(214, 64);
            txtBoxAddProduto.Name = "txtBoxAddProduto";
            txtBoxAddProduto.Size = new Size(169, 23);
            txtBoxAddProduto.TabIndex = 1;
            txtBoxAddProduto.TextChanged += txtBoxAddProdito_TextChanged;
            // 
            // txtBoxAddPreco
            // 
            txtBoxAddPreco.Location = new Point(214, 104);
            txtBoxAddPreco.Name = "txtBoxAddPreco";
            txtBoxAddPreco.Size = new Size(169, 23);
            txtBoxAddPreco.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 112);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Adicionar Preço";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(308, 147);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listBoxTest
            // 
            listBoxTest.FormattingEnabled = true;
            listBoxTest.ItemHeight = 15;
            listBoxTest.Location = new Point(466, 64);
            listBoxTest.Name = "listBoxTest";
            listBoxTest.Size = new Size(148, 229);
            listBoxTest.TabIndex = 5;
            // 
            // formsAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxTest);
            Controls.Add(btnAdicionar);
            Controls.Add(label2);
            Controls.Add(txtBoxAddPreco);
            Controls.Add(txtBoxAddProduto);
            Controls.Add(label1);
            Name = "formsAdm";
            Text = "Adm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxAddProduto;
        private TextBox txtBoxAddPreco;
        private Label label2;
        private Button btnAdicionar;
        private ListBox listBoxTest;
    }
}