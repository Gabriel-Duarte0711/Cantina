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
            btnEditar = new Button();
            listBoxTest = new ListBox();
            lblPreco = new Label();
            txtBoxPreco = new TextBox();
            checkBox1 = new CheckBox();
            btnAtivo = new Button();
            btnNoAtivo = new Button();
            btnAdicionar = new Button();
            pictureBoxLogo = new PictureBox();
            lblTitulo = new Label();
            separator = new Panel();
            pictureBox1 = new PictureBox();
            comboBoxMenu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Font = new Font("Inter", 10F);
            lblCodigo.ForeColor = Color.FromArgb(243, 241, 238);
            lblCodigo.Location = new Point(320, 80);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(134, 21);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código do Produto";
            // 
            // txtBoxCodigo
            // 
            txtBoxCodigo.BackColor = Color.FromArgb(120, 118, 100);
            txtBoxCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtBoxCodigo.Font = new Font("Inter", 10F);
            txtBoxCodigo.ForeColor = Color.FromArgb(243, 241, 238);
            txtBoxCodigo.Location = new Point(320, 105);
            txtBoxCodigo.Name = "txtBoxCodigo";
            txtBoxCodigo.Size = new Size(220, 24);
            txtBoxCodigo.TabIndex = 1;
            txtBoxCodigo.TextChanged += txtBoxAddProdito_TextChanged;
            txtBoxCodigo.KeyPress += txtBoxCodigo_KeyPress;
            // 
            // txtBoxProduto
            // 
            txtBoxProduto.BackColor = Color.FromArgb(120, 118, 100);
            txtBoxProduto.BorderStyle = BorderStyle.FixedSingle;
            txtBoxProduto.Font = new Font("Inter", 10F);
            txtBoxProduto.ForeColor = Color.FromArgb(243, 241, 238);
            txtBoxProduto.Location = new Point(320, 165);
            txtBoxProduto.Name = "txtBoxProduto";
            txtBoxProduto.Size = new Size(220, 24);
            txtBoxProduto.TabIndex = 2;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.BackColor = Color.Transparent;
            lblProduto.Font = new Font("Inter", 10F);
            lblProduto.ForeColor = Color.FromArgb(243, 241, 238);
            lblProduto.Location = new Point(320, 140);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(126, 21);
            lblProduto.TabIndex = 3;
            lblProduto.Text = "Nome do Produto";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(120, 118, 100);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Inter", 9F);
            btnEditar.ForeColor = Color.FromArgb(243, 241, 238);
            btnEditar.Location = new Point(320, 370);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 45);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // listBoxTest
            // 
            listBoxTest.BackColor = Color.FromArgb(120, 118, 100);
            listBoxTest.BorderStyle = BorderStyle.FixedSingle;
            listBoxTest.Font = new Font("Inter", 10F);
            listBoxTest.ForeColor = Color.FromArgb(243, 241, 238);
            listBoxTest.FormattingEnabled = true;
            listBoxTest.ItemHeight = 18;
            listBoxTest.Location = new Point(30, 80);
            listBoxTest.Name = "listBoxTest";
            listBoxTest.Size = new Size(260, 398);
            listBoxTest.TabIndex = 5;
            listBoxTest.SelectedIndexChanged += listBoxTest_SelectedIndexChanged;
            listBoxTest.MouseDown += listBox1_MouseDown;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.BackColor = Color.Transparent;
            lblPreco.Font = new Font("Inter", 10F);
            lblPreco.ForeColor = Color.FromArgb(243, 241, 238);
            lblPreco.Location = new Point(320, 200);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(80, 21);
            lblPreco.TabIndex = 6;
            lblPreco.Text = "Preço (R$)";
            // 
            // txtBoxPreco
            // 
            txtBoxPreco.BackColor = Color.FromArgb(120, 118, 100);
            txtBoxPreco.BorderStyle = BorderStyle.FixedSingle;
            txtBoxPreco.Font = new Font("Inter", 10F);
            txtBoxPreco.ForeColor = Color.FromArgb(243, 241, 238);
            txtBoxPreco.Location = new Point(320, 225);
            txtBoxPreco.Name = "txtBoxPreco";
            txtBoxPreco.Size = new Size(220, 24);
            txtBoxPreco.TabIndex = 8;
            txtBoxPreco.KeyPress += txtBoxPreco_KeyPress_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Inter", 10F);
            checkBox1.ForeColor = Color.FromArgb(243, 241, 238);
            checkBox1.Location = new Point(320, 265);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(149, 25);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Produto da Chapa";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // btnAtivo
            // 
            btnAtivo.BackColor = Color.FromArgb(46, 125, 50);
            btnAtivo.Cursor = Cursors.Hand;
            btnAtivo.FlatAppearance.BorderSize = 0;
            btnAtivo.FlatStyle = FlatStyle.Flat;
            btnAtivo.Font = new Font("Inter", 9F);
            btnAtivo.ForeColor = Color.White;
            btnAtivo.Location = new Point(480, 370);
            btnAtivo.Name = "btnAtivo";
            btnAtivo.Size = new Size(140, 45);
            btnAtivo.TabIndex = 10;
            btnAtivo.Text = "ATIVAR ITEM";
            btnAtivo.UseVisualStyleBackColor = false;
            btnAtivo.Click += btnAtivo_Click;
            // 
            // btnNoAtivo
            // 
            btnNoAtivo.BackColor = Color.FromArgb(183, 28, 28);
            btnNoAtivo.Cursor = Cursors.Hand;
            btnNoAtivo.FlatAppearance.BorderSize = 0;
            btnNoAtivo.FlatStyle = FlatStyle.Flat;
            btnNoAtivo.Font = new Font("Inter", 9F);
            btnNoAtivo.ForeColor = Color.White;
            btnNoAtivo.Location = new Point(480, 430);
            btnNoAtivo.Name = "btnNoAtivo";
            btnNoAtivo.Size = new Size(140, 45);
            btnNoAtivo.TabIndex = 11;
            btnNoAtivo.Text = "DESATIVAR ITEM";
            btnNoAtivo.UseVisualStyleBackColor = false;
            btnNoAtivo.Click += btnNoAtivo_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(225, 255, 0);
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Inter", 9F);
            btnAdicionar.ForeColor = Color.FromArgb(17, 25, 12);
            btnAdicionar.Location = new Point(320, 310);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(140, 45);
            btnAdicionar.TabIndex = 12;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Location = new Point(30, 20);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(120, 40);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 14;
            pictureBoxLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(243, 241, 238);
            lblTitulo.Location = new Point(160, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(176, 20);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Painel Administrativo";
            // 
            // separator
            // 
            separator.BackColor = Color.FromArgb(120, 118, 100);
            separator.Location = new Point(310, 70);
            separator.Name = "separator";
            separator.Size = new Size(2, 420);
            separator.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // comboBoxMenu
            // 
            comboBoxMenu.BackColor = Color.FromArgb(202, 196, 183);
            comboBoxMenu.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMenu.FlatStyle = FlatStyle.Flat;
            comboBoxMenu.Font = new Font("Inter", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxMenu.ForeColor = Color.FromArgb(17, 25, 12);
            comboBoxMenu.FormattingEnabled = true;
            comboBoxMenu.Location = new Point(791, 20);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(87, 30);
            comboBoxMenu.TabIndex = 32;
            comboBoxMenu.Tag = "";
            comboBoxMenu.SelectedIndexChanged += comboBoxMenu_SelectedIndexChanged;
            // 
            // formsAdm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(900, 550);
            Controls.Add(comboBoxMenu);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(separator);
            Controls.Add(lblTitulo);
            Controls.Add(btnAdicionar);
            Controls.Add(btnNoAtivo);
            Controls.Add(btnAtivo);
            Controls.Add(checkBox1);
            Controls.Add(txtBoxPreco);
            Controls.Add(lblPreco);
            Controls.Add(listBoxTest);
            Controls.Add(btnEditar);
            Controls.Add(lblProduto);
            Controls.Add(txtBoxProduto);
            Controls.Add(txtBoxCodigo);
            Controls.Add(lblCodigo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "formsAdm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cantina Painel - Administração";
            Activated += formsAdm_Activated;
            Load += formsAdm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private TextBox txtBoxCodigo;
        private TextBox txtBoxProduto;
        private Label lblProduto;
        private Button btnEditar;
        private ListBox listBoxTest;
        private Label lblPreco;
        private TextBox txtBoxPreco;
        private CheckBox checkBox1;
        private Button btnAtivo;
        private Button btnNoAtivo;
        private Button btnAdicionar;
        private PictureBox pictureBoxLogo;
        private Label lblTitulo;
        private Panel separator;
        private PictureBox pictureBox1;
        private ComboBox comboBoxMenu;
    }
}