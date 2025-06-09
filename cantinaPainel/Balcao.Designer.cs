namespace cantinaPainel
{
    partial class formsBalcao
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelPedidos = new Label();
            labelHistorico = new Label();
            btnEntregar = new Button();
            btnVoltar = new Button();
            listBoxPedidos = new ListBox();
            listBoxHistorico = new ListBox();
            pictureBoxLogo = new PictureBox();
            btnChamada = new Button();
            panelHeader = new Panel();
            lblSubtitle = new Label();
            panelMain = new Panel();
            panelPedidos = new Panel();
            lblContadorPedidos = new Label();
            panelHistorico = new Panel();
            panelButtons = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelPedidos.SuspendLayout();
            panelHistorico.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Inter", 36F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(243, 241, 238);
            labelTitle.Location = new Point(90, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(187, 68);
            labelTitle.TabIndex = 8;
            labelTitle.Text = "Balcão";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPedidos
            // 
            labelPedidos.AutoSize = true;
            labelPedidos.Font = new Font("Inter", 20F, FontStyle.Bold);
            labelPedidos.ForeColor = Color.FromArgb(243, 241, 238);
            labelPedidos.Location = new Point(25, 20);
            labelPedidos.Name = "labelPedidos";
            labelPedidos.Size = new Size(270, 39);
            labelPedidos.TabIndex = 7;
            labelPedidos.Text = "Pedidos Pendentes";
            // 
            // labelHistorico
            // 
            labelHistorico.AutoSize = true;
            labelHistorico.Font = new Font("Inter", 18F, FontStyle.Bold);
            labelHistorico.ForeColor = Color.FromArgb(243, 241, 238);
            labelHistorico.Location = new Point(25, 0);
            labelHistorico.Name = "labelHistorico";
            labelHistorico.Size = new Size(123, 35);
            labelHistorico.TabIndex = 6;
            labelHistorico.Text = "Histórico";
            // 
            // btnEntregar
            // 
            btnEntregar.BackColor = Color.FromArgb(225, 255, 0);
            btnEntregar.FlatAppearance.BorderSize = 0;
            btnEntregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 230, 0);
            btnEntregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 240, 0);
            btnEntregar.FlatStyle = FlatStyle.Flat;
            btnEntregar.Font = new Font("Inter", 16F, FontStyle.Bold);
            btnEntregar.ForeColor = Color.FromArgb(17, 25, 12);
            btnEntregar.Location = new Point(3, 3);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(241, 45);
            btnEntregar.TabIndex = 5;
            btnEntregar.Text = "⚡ Entregar Pedido";
            btnEntregar.UseVisualStyleBackColor = false;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(225, 255, 0);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatAppearance.MouseDownBackColor = Color.FromArgb(200, 230, 0);
            btnVoltar.FlatAppearance.MouseOverBackColor = Color.FromArgb(210, 240, 0);
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Inter", 16F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.FromArgb(17, 25, 12);
            btnVoltar.Location = new Point(20, 30);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(50, 40);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "←";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // listBoxPedidos
            // 
            listBoxPedidos.BackColor = Color.FromArgb(202, 196, 183);
            listBoxPedidos.BorderStyle = BorderStyle.None;
            listBoxPedidos.Font = new Font("Inter", 12F);
            listBoxPedidos.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxPedidos.ItemHeight = 23;
            listBoxPedidos.Location = new Point(25, 75);
            listBoxPedidos.Name = "listBoxPedidos";
            listBoxPedidos.Size = new Size(770, 276);
            listBoxPedidos.TabIndex = 3;
            listBoxPedidos.SelectedIndexChanged += listBoxPedidos_SelectedIndexChanged;
            // 
            // listBoxHistorico
            // 
            listBoxHistorico.BackColor = Color.FromArgb(202, 196, 183);
            listBoxHistorico.BorderStyle = BorderStyle.None;
            listBoxHistorico.Font = new Font("Inter", 11F);
            listBoxHistorico.ForeColor = Color.FromArgb(17, 25, 12);
            listBoxHistorico.ItemHeight = 22;
            listBoxHistorico.Location = new Point(22, 47);
            listBoxHistorico.Name = "listBoxHistorico";
            listBoxHistorico.Size = new Size(770, 110);
            listBoxHistorico.TabIndex = 2;
            listBoxHistorico.SelectedIndexChanged += listBoxHistorico_SelectedIndexChanged;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBoxLogo.Location = new Point(950, 30);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(130, 40);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            // 
            // btnChamada
            // 
            btnChamada.BackColor = Color.FromArgb(120, 118, 100);
            btnChamada.FlatAppearance.BorderColor = Color.FromArgb(225, 255, 0);
            btnChamada.FlatAppearance.BorderSize = 2;
            btnChamada.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 98, 80);
            btnChamada.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 108, 90);
            btnChamada.FlatStyle = FlatStyle.Flat;
            btnChamada.Font = new Font("Inter", 16F, FontStyle.Bold);
            btnChamada.ForeColor = Color.FromArgb(243, 241, 238);
            btnChamada.Location = new Point(894, 471);
            btnChamada.Name = "btnChamada";
            btnChamada.Size = new Size(194, 44);
            btnChamada.TabIndex = 0;
            btnChamada.Text = "Chamada";
            btnChamada.UseVisualStyleBackColor = false;
            btnChamada.Click += button1_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 25, 12);
            panelHeader.Controls.Add(btnVoltar);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Controls.Add(lblSubtitle);
            panelHeader.Controls.Add(pictureBoxLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1117, 100);
            panelHeader.TabIndex = 20;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Inter", 14F);
            lblSubtitle.ForeColor = Color.FromArgb(243, 241, 238);
            lblSubtitle.Location = new Point(95, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(343, 27);
            lblSubtitle.TabIndex = 26;
            lblSubtitle.Text = "Gestão rápida e eficiente de pedidos";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(17, 25, 12);
            panelMain.Controls.Add(panelPedidos);
            panelMain.Controls.Add(btnChamada);
            panelMain.Controls.Add(panelHistorico);
            panelMain.Controls.Add(panelButtons);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 100);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(1117, 576);
            panelMain.TabIndex = 21;
            panelMain.Paint += panelMain_Paint_1;
            // 
            // panelPedidos
            // 
            panelPedidos.BackColor = Color.FromArgb(120, 118, 100);
            panelPedidos.Controls.Add(labelPedidos);
            panelPedidos.Controls.Add(lblContadorPedidos);
            panelPedidos.Controls.Add(listBoxPedidos);
            panelPedidos.Location = new Point(30, 20);
            panelPedidos.Name = "panelPedidos";
            panelPedidos.Padding = new Padding(25);
            panelPedidos.Size = new Size(820, 366);
            panelPedidos.TabIndex = 22;
            // 
            // lblContadorPedidos
            // 
            lblContadorPedidos.AutoSize = true;
            lblContadorPedidos.BackColor = Color.FromArgb(225, 255, 0);
            lblContadorPedidos.Font = new Font("Inter", 16F, FontStyle.Bold);
            lblContadorPedidos.ForeColor = Color.FromArgb(17, 25, 12);
            lblContadorPedidos.Location = new Point(301, 20);
            lblContadorPedidos.Name = "lblContadorPedidos";
            lblContadorPedidos.Padding = new Padding(8, 4, 8, 4);
            lblContadorPedidos.Size = new Size(45, 39);
            lblContadorPedidos.TabIndex = 23;
            lblContadorPedidos.Text = "0";
            lblContadorPedidos.Click += lblContadorPedidos_Click;
            // 
            // panelHistorico
            // 
            panelHistorico.BackColor = Color.FromArgb(120, 118, 100);
            panelHistorico.Controls.Add(labelHistorico);
            panelHistorico.Controls.Add(listBoxHistorico);
            panelHistorico.Location = new Point(30, 392);
            panelHistorico.Name = "panelHistorico";
            panelHistorico.Padding = new Padding(25);
            panelHistorico.Size = new Size(820, 174);
            panelHistorico.TabIndex = 24;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Transparent;
            panelButtons.Controls.Add(btnEntregar);
            panelButtons.Location = new Point(856, 20);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(255, 169);
            panelButtons.TabIndex = 25;
            // 
            // formsBalcao
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1117, 676);
            Controls.Add(panelMain);
            Controls.Add(panelHeader);
            Font = new Font("Inter", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "formsBalcao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Balcão - Cantina";
            Load += formsBalcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelPedidos.ResumeLayout(false);
            panelPedidos.PerformLayout();
            panelHistorico.ResumeLayout(false);
            panelHistorico.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTitle;
        private Label labelPedidos;
        private Label labelHistorico;
        private Button btnEntregar;
        private Button btnVoltar;
        private ListBox listBoxPedidos;
        private ListBox listBoxHistorico;
        private PictureBox pictureBoxLogo;
        private Button btnChamada;
        private Panel panelHeader;
        private Panel panelMain;
        private Panel panelPedidos;
        private Panel panelHistorico;
        private Panel panelButtons;
        private Label lblContadorPedidos;
        private Label lblSubtitle;
    }
}