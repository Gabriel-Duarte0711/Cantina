namespace cantinaPainel
{
    partial class formsBalcao
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnEntregar = new Button();
            btnVoltar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listBoxPedidos = new ListBox();
            listBoxHistorico = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(38, 68);
            label1.Name = "label1";
            label1.Size = new Size(102, 37);
            label1.TabIndex = 0;
            label1.Text = "Balcão";
            // 
            // btnEntregar
            // 
            btnEntregar.BackColor = Color.FromArgb(17, 25, 12);
            btnEntregar.ForeColor = Color.FromArgb(230, 255, 0);
            btnEntregar.Location = new Point(613, 323);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(126, 40);
            btnEntregar.TabIndex = 1;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = false;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(17, 25, 12);
            btnVoltar.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnVoltar.ForeColor = Color.FromArgb(230, 255, 0);
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(37, 36);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "<";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listBoxPedidos
            // 
            listBoxPedidos.FormattingEnabled = true;
            listBoxPedidos.ItemHeight = 15;
            listBoxPedidos.Location = new Point(38, 108);
            listBoxPedidos.Name = "listBoxPedidos";
            listBoxPedidos.Size = new Size(701, 199);
            listBoxPedidos.TabIndex = 6;
            // 
            // listBoxHistorico
            // 
            listBoxHistorico.FormattingEnabled = true;
            listBoxHistorico.ItemHeight = 15;
            listBoxHistorico.Location = new Point(38, 386);
            listBoxHistorico.Name = "listBoxHistorico";
            listBoxHistorico.Size = new Size(701, 169);
            listBoxHistorico.TabIndex = 7;
            listBoxHistorico.SelectedIndexChanged += listBoxHistorico_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(163, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // formsBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 567);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxHistorico);
            Controls.Add(listBoxPedidos);
            Controls.Add(btnVoltar);
            Controls.Add(btnEntregar);
            Controls.Add(label1);
            Name = "formsBalcao";
            Text = "formsBalcao";
            Load += formsBalcao_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEntregar;
        private Button btnVoltar;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox listBoxPedidos;
        private ListBox listBoxHistorico;
        private PictureBox pictureBox1;
    }
}