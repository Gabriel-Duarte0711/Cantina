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
            lblCodigo = new Label();
            txtBoxCodigo = new TextBox();
            txtBoxProduto = new TextBox();
            lblProduto = new Label();
            btnAdicionar = new Button();
            listBoxTest = new ListBox();
            lblPreco = new Label();
            txtBoxPreco = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(288, 72);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(100, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Adicionar Código";
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.Location = new Point(412, 64);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(169, 23);
            txtBoxCodigo.TabIndex = 1;
            txtBoxCodigo.TextChanged += txtBoxAddProdito_TextChanged;
            // 
            // txtBoxProduto
            // 
            txtBoxProduto.Location = new Point(412, 95);
            txtBoxProduto.Name = "txtBoxProduto";
            txtBoxProduto.Size = new Size(169, 23);
            txtBoxProduto.TabIndex = 2;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(288, 103);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(104, 15);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Adicionar Produto";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(412, 198);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(169, 43);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // listBoxTest
            // 
            listBoxTest.FormattingEnabled = true;
            listBoxTest.ItemHeight = 15;
            listBoxTest.Location = new Point(12, 64);
            listBoxTest.Name = "listBoxTest";
            listBoxTest.Size = new Size(240, 364);
            listBoxTest.TabIndex = 5;
            listBoxTest.SelectedIndexChanged += listBoxTest_SelectedIndexChanged;
            listBoxTest.MouseDown += listBox1_MouseDown;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(288, 137);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(91, 15);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Adicionar Preço";
            // 
            // txtBoxPreco
            // 
            txtBoxPreco.Location = new Point(412, 129);
            txtBoxPreco.Name = "txtBoxPreco";
            txtBoxPreco.Size = new Size(169, 23);
            txtBoxPreco.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(412, 158);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Chapa";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // formsAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(txtBoxPreco);
            Controls.Add(lblPreco);
            Controls.Add(listBoxTest);
            Controls.Add(btnAdicionar);
            Controls.Add(lblProduto);
            Controls.Add(txtBoxProduto);
            Controls.Add(txtBoxCodigo);
            Controls.Add(lblCodigo);
            Name = "formsAdm";
            Text = "Adm";
            Load += formsAdm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtBoxCodigo;
        private TextBox txtBoxProduto;
        private Label lblProduto;
        private Button btnAdicionar;
        private ListBox listBoxTest;
        private Label lblPreco;
        private TextBox txtBoxPreco;
        private CheckBox checkBox1;
    }
}