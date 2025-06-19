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
            btnRemover = new Button();
            numericUpDown1 = new NumericUpDown();
            lblTitulo = new Label();
            lblQuantidade = new Label();
            pictureBox1 = new PictureBox();
            comboBoxMenu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxEstoque
            // 
            listBoxEstoque.BackColor = Color.FromArgb(120, 118, 100);
            listBoxEstoque.BorderStyle = BorderStyle.None;
            listBoxEstoque.Font = new Font("Inter", 10F);
            listBoxEstoque.ForeColor = Color.FromArgb(243, 241, 238);
            listBoxEstoque.FormattingEnabled = true;
            listBoxEstoque.ItemHeight = 18;
            listBoxEstoque.Location = new Point(50, 80);
            listBoxEstoque.Name = "listBoxEstoque";
            listBoxEstoque.ScrollAlwaysVisible = true;
            listBoxEstoque.Size = new Size(400, 324);
            listBoxEstoque.TabIndex = 0;
            listBoxEstoque.SelectedIndexChanged += listBoxEstoque_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(225, 255, 0);
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Inter", 10F, FontStyle.Bold);
            btnAdicionar.ForeColor = Color.FromArgb(17, 25, 12);
            btnAdicionar.Location = new Point(480, 120);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(140, 45);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "⚡ Adicionar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(120, 118, 100);
            btnRemover.Cursor = Cursors.Hand;
            btnRemover.FlatAppearance.BorderSize = 0;
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Inter", 10F, FontStyle.Bold);
            btnRemover.ForeColor = Color.FromArgb(243, 241, 238);
            btnRemover.Location = new Point(480, 185);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(140, 45);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(120, 118, 100);
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.Font = new Font("Inter", 12F, FontStyle.Bold);
            numericUpDown1.ForeColor = Color.FromArgb(243, 241, 238);
            numericUpDown1.Location = new Point(480, 290);
            numericUpDown1.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(140, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(243, 241, 238);
            lblTitulo.Location = new Point(190, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 35);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Controle de Estoque";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblQuantidade
            // 
            lblQuantidade.Font = new Font("Inter", 11F, FontStyle.Bold);
            lblQuantidade.ForeColor = Color.FromArgb(243, 241, 238);
            lblQuantidade.Location = new Point(480, 260);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(140, 25);
            lblQuantidade.TabIndex = 5;
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(50, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
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
            comboBoxMenu.Location = new Point(533, 15);
            comboBoxMenu.Name = "comboBoxMenu";
            comboBoxMenu.Size = new Size(87, 30);
            comboBoxMenu.TabIndex = 37;
            comboBoxMenu.Tag = "";
            comboBoxMenu.SelectedIndexChanged += comboBoxMenu_SelectedIndexChanged;
            // 
            // formsEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(700, 460);
            Controls.Add(comboBoxMenu);
            Controls.Add(pictureBox1);
            Controls.Add(lblQuantidade);
            Controls.Add(lblTitulo);
            Controls.Add(numericUpDown1);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listBoxEstoque);
            Font = new Font("Inter", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "formsEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Load += telaEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEstoque;
        private Button btnAdicionar;
        private Button btnRemover;
        private NumericUpDown numericUpDown1;
        private Label lblTitulo;
        private Label lblQuantidade;
        private PictureBox pictureBox1;
        private ComboBox comboBoxMenu;
    }
}