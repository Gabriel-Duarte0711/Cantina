namespace cantinaPainel
{
    partial class formsTela
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
            listBoxNomePreparando = new ListBox();
            listBoxNomePronto = new ListBox();
            buttonVoltar = new Button();
            pictureBox1 = new PictureBox();
            labelPronto = new Label();
            labelPreparando = new Label();
            labelTitulo = new Label();
            panelPreparando = new Panel();
            panelPronto = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPreparando.SuspendLayout();
            panelPronto.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxNomePreparando
            // 
            listBoxNomePreparando.BackColor = Color.FromArgb(202, 196, 183);
            listBoxNomePreparando.BorderStyle = BorderStyle.None;
            listBoxNomePreparando.Font = new Font("Inter", 12F);
            listBoxNomePreparando.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxNomePreparando.FormattingEnabled = true;
            listBoxNomePreparando.ItemHeight = 23;
            listBoxNomePreparando.Location = new Point(15, 15);
            listBoxNomePreparando.Name = "listBoxNomePreparando";
            listBoxNomePreparando.Size = new Size(220, 299);
            listBoxNomePreparando.TabIndex = 0;
            // 
            // listBoxNomePronto
            // 
            listBoxNomePronto.BackColor = Color.FromArgb(225, 255, 0);
            listBoxNomePronto.BorderStyle = BorderStyle.None;
            listBoxNomePronto.Font = new Font("Inter", 12F, FontStyle.Bold);
            listBoxNomePronto.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxNomePronto.FormattingEnabled = true;
            listBoxNomePronto.ItemHeight = 23;
            listBoxNomePronto.Location = new Point(15, 15);
            listBoxNomePronto.Name = "listBoxNomePronto";
            listBoxNomePronto.Size = new Size(220, 299);
            listBoxNomePronto.TabIndex = 1;
            listBoxNomePronto.SelectedIndexChanged += listBoxNomePronto_SelectedIndexChanged;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.FromArgb(243, 241, 238);
            buttonVoltar.FlatAppearance.BorderSize = 0;
            buttonVoltar.FlatStyle = FlatStyle.Flat;
            buttonVoltar.Font = new Font("Inter", 14F);
            buttonVoltar.ForeColor = Color.FromArgb(17, 25, 12);
            buttonVoltar.Location = new Point(20, 20);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(60, 40);
            buttonVoltar.TabIndex = 2;
            buttonVoltar.Text = "←";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(100, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // labelPronto
            // 
            labelPronto.AutoSize = true;
            labelPronto.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            labelPronto.ForeColor = Color.FromArgb(225, 255, 0);
            labelPronto.Location = new Point(420, 130);
            labelPronto.Name = "labelPronto";
            labelPronto.Size = new Size(160, 37);
            labelPronto.TabIndex = 29;
            labelPronto.Text = "PRONTO";
            // 
            // labelPreparando
            // 
            labelPreparando.AutoSize = true;
            labelPreparando.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            labelPreparando.ForeColor = Color.FromArgb(243, 241, 238);
            labelPreparando.Location = new Point(89, 130);
            labelPreparando.Name = "labelPreparando";
            labelPreparando.Size = new Size(250, 37);
            labelPreparando.TabIndex = 30;
            labelPreparando.Text = "PREPARANDO";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(243, 241, 238);
            labelTitulo.Location = new Point(230, 86);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(335, 44);
            labelTitulo.TabIndex = 31;
            labelTitulo.Text = "Painel da Cantina";
            labelTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelPreparando
            // 
            panelPreparando.BackColor = Color.FromArgb(120, 118, 100);
            panelPreparando.Controls.Add(listBoxNomePreparando);
            panelPreparando.Location = new Point(80, 170);
            panelPreparando.Name = "panelPreparando";
            panelPreparando.Padding = new Padding(15);
            panelPreparando.Size = new Size(259, 340);
            panelPreparando.TabIndex = 32;
            // 
            // panelPronto
            // 
            panelPronto.BackColor = Color.FromArgb(120, 118, 100);
            panelPronto.Controls.Add(listBoxNomePronto);
            panelPronto.Location = new Point(370, 170);
            panelPronto.Name = "panelPronto";
            panelPronto.Padding = new Padding(15);
            panelPronto.Size = new Size(250, 340);
            panelPronto.TabIndex = 33;
            // 
            // formsTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 550);
            Controls.Add(labelPreparando);
            Controls.Add(labelPronto);
            Controls.Add(panelPronto);
            Controls.Add(panelPreparando);
            Controls.Add(labelTitulo);
            Controls.Add(pictureBox1);
            Controls.Add(buttonVoltar);
            Name = "formsTela";
            Text = "Cantina Painel - Bolt Design";
            Load += formsTela_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPreparando.ResumeLayout(false);
            panelPronto.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #region Cores Bolt Brand Guidelines
        // Cores primárias conforme documento Bolt
        // Lightning Yellow: #E1FF00 (RGB: 225, 255, 0)
        // Bolt Black: #11190C (RGB: 17, 25, 12)
        // Dark Grey: #787664 (RGB: 120, 118, 100)
        // Mid Grey: #CAC4B7 (RGB: 202, 196, 183)
        // Light Grey: #F3F1EE (RGB: 243, 241, 238)
        #endregion

        #endregion

        private ListBox listBoxNomePreparando;
        private ListBox listBoxNomePronto;
        private Button buttonVoltar;
        private PictureBox pictureBox1;
        private Label labelPronto;
        private Label labelPreparando;
        private Label labelTitulo;
        private Panel panelPreparando;
        private Panel panelPronto;
    }
}