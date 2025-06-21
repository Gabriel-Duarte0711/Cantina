namespace cantinaPainel
{
    partial class ChamadaGigante
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
            timerAnimacao = new System.Windows.Forms.Timer(components);
            panelCentral = new Panel();
            panelProduto = new Panel();
            label1 = new Label();
            panelIcone = new Panel();
            lblIconeCheck = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            saveFileDialog1 = new SaveFileDialog();
            panelCentral.SuspendLayout();
            panelProduto.SuspendLayout();
            panelIcone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timerAnimacao
            // 
            timerAnimacao.Enabled = true;
            timerAnimacao.Interval = 3000;
            timerAnimacao.Tick += timerAnimacao_Tick;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.FromArgb(202, 196, 183);
            panelCentral.Controls.Add(panelProduto);
            panelCentral.Controls.Add(panelIcone);
            panelCentral.Controls.Add(lblSubtitulo);
            panelCentral.Controls.Add(lblTitulo);
            panelCentral.Location = new Point(42, 75);
            panelCentral.Name = "panelCentral";
            panelCentral.Padding = new Padding(52, 75, 52, 56);
            panelCentral.Size = new Size(962, 457);
            panelCentral.TabIndex = 0;
            // 
            // panelProduto
            // 
            panelProduto.BackColor = Color.FromArgb(202, 196, 183);
            panelProduto.Controls.Add(label1);
            panelProduto.Location = new Point(175, 356);
            panelProduto.Name = "panelProduto";
            panelProduto.Padding = new Padding(26, 28, 26, 28);
            panelProduto.Size = new Size(612, 81);
            panelProduto.TabIndex = 2;
            panelProduto.Paint += panelProduto_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(255, 23);
            label1.Name = "label1";
            label1.Size = new Size(90, 37);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // panelIcone
            // 
            panelIcone.BackColor = Color.FromArgb(202, 196, 183);
            panelIcone.Controls.Add(lblIconeCheck);
            panelIcone.Location = new Point(439, 0);
            panelIcone.Name = "panelIcone";
            panelIcone.Size = new Size(88, 94);
            panelIcone.TabIndex = 5;
            // 
            // lblIconeCheck
            // 
            lblIconeCheck.BackColor = Color.Transparent;
            lblIconeCheck.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIconeCheck.ForeColor = Color.FromArgb(230, 255, 0);
            lblIconeCheck.Location = new Point(0, 0);
            lblIconeCheck.Name = "lblIconeCheck";
            lblIconeCheck.Size = new Size(88, 94);
            lblIconeCheck.TabIndex = 0;
            lblIconeCheck.Text = "⚡";
            lblIconeCheck.TextAlign = ContentAlignment.MiddleCenter;
            lblIconeCheck.Click += lblIconeCheck_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(102, 102, 102);
            lblSubtitulo.Location = new Point(32, 279);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(858, 47);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Dirija-se ao balcão para retirar seu pedido";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(17, 25, 12);
            lblTitulo.Location = new Point(103, 97);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(804, 182);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SEU PEDIDO ESTÁ PRONTO!";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(202, 196, 183);
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(391, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // ChamadaGigante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1045, 549);
            Controls.Add(pictureBox1);
            Controls.Add(panelCentral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChamadaGigante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produto Pronto - Cantina";
            TopMost = true;
            Load += ChamadaGigante_Load_1;
            panelCentral.ResumeLayout(false);
            panelProduto.ResumeLayout(false);
            panelProduto.PerformLayout();
            panelIcone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAnimacao;
        private Panel panelCentral;
        private Panel panelProduto;
        private Label label1;
        private Panel panelIcone;
        private Label lblIconeCheck;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private SaveFileDialog saveFileDialog1;
    }
}