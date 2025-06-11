namespace cantinaPainel
{
    partial class formsCozinha
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
            btnVoltar = new Button();
            btnFeito = new Button();
            pictureBox1 = new PictureBox();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelHeader = new Panel();
            panelActions = new Panel();
            listBoxChapa = new ListBox();
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            panelActions.SuspendLayout();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(230, 255, 0);
            btnVoltar.FlatAppearance.BorderSize = 0;
            btnVoltar.FlatStyle = FlatStyle.Flat;
            btnVoltar.Font = new Font("Inter", 18F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.FromArgb(17, 25, 12);
            btnVoltar.Location = new Point(24, 24);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(60, 60);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "←";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += button1_Click;
            // 
            // btnFeito
            // 
            btnFeito.BackColor = Color.FromArgb(230, 255, 0);
            btnFeito.Dock = DockStyle.Fill;
            btnFeito.FlatAppearance.BorderSize = 0;
            btnFeito.FlatStyle = FlatStyle.Flat;
            btnFeito.Font = new Font("Inter", 18F, FontStyle.Bold);
            btnFeito.ForeColor = Color.FromArgb(17, 25, 12);
            btnFeito.Location = new Point(32, 16);
            btnFeito.Name = "btnFeito";
            btnFeito.Padding = new Padding(0, 8, 0, 8);
            btnFeito.Size = new Size(1549, 53);
            btnFeito.TabIndex = 2;
            btnFeito.Text = "Marcar como Feito ⚡";
            btnFeito.UseVisualStyleBackColor = false;
            btnFeito.Click += btnFeito_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(104, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 32F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(230, 255, 0);
            lblTitulo.Location = new Point(330, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(188, 51);
            lblTitulo.TabIndex = 29;
            lblTitulo.Text = "Cozinha";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Microsoft Sans Serif", 18F);
            lblSubtitulo.ForeColor = Color.LightGray;
            lblSubtitulo.Location = new Point(330, 72);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(359, 29);
            lblSubtitulo.TabIndex = 31;
            lblSubtitulo.Text = "Gerencie os pedidos da cozinha";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 25, 12);
            panelHeader.Controls.Add(btnVoltar);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(24);
            panelHeader.Size = new Size(1613, 120);
            panelHeader.TabIndex = 30;
            panelHeader.Paint += panelHeader_Paint;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.FromArgb(17, 25, 12);
            panelActions.Controls.Add(btnFeito);
            panelActions.Dock = DockStyle.Bottom;
            panelActions.Location = new Point(0, 552);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(32, 16, 32, 24);
            panelActions.Size = new Size(1613, 93);
            panelActions.TabIndex = 33;
            // 
            // listBoxChapa
            // 
            listBoxChapa.BackColor = Color.FromArgb(202, 196, 183);
            listBoxChapa.BorderStyle = BorderStyle.None;
            listBoxChapa.Dock = DockStyle.Fill;
            listBoxChapa.Font = new Font("Inter", 14F);
            listBoxChapa.ForeColor = Color.Black;
            listBoxChapa.FormattingEnabled = true;
            listBoxChapa.ItemHeight = 27;
            listBoxChapa.Location = new Point(32, 32);
            listBoxChapa.Name = "listBoxChapa";
            listBoxChapa.Size = new Size(1549, 368);
            listBoxChapa.TabIndex = 0;
            listBoxChapa.SelectedIndexChanged += listBoxChapa_SelectedIndexChanged;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(17, 25, 12);
            panelMain.Controls.Add(listBoxChapa);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 120);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(32);
            panelMain.Size = new Size(1613, 432);
            panelMain.TabIndex = 32;
            panelMain.Paint += panelMain_Paint;
            // 
            // formsCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1613, 645);
            Controls.Add(panelMain);
            Controls.Add(panelActions);
            Controls.Add(panelHeader);
            Font = new Font("Inter", 9F);
            Name = "formsCozinha";
            Text = "Cozinha - Sistema Cantina";
            Load += formsCozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelActions.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Button btnVoltar;
        private Button btnFeito;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private Panel panelActions;

        // Bordas arredondadas
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private ListBox listBoxChapa;
        private Panel panelMain;
    }
}
