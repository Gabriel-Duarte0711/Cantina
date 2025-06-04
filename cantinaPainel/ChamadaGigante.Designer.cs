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
            panelPrincipal = new Panel();
            panelCentral = new Panel();
            panelProduto = new Panel();
            panelIcone = new Panel();
            lblIconeCheck = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            timerAnimacao = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            panelCentral.SuspendLayout();
            panelProduto.SuspendLayout();
            panelIcone.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(17, 25, 12);
            panelPrincipal.Controls.Add(panelCentral);
            panelPrincipal.Location = new Point(-1, 0);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Padding = new Padding(44, 47, 44, 47);
            panelPrincipal.Size = new Size(1051, 595);
            panelPrincipal.TabIndex = 0;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // panelCentral
            // 
            panelCentral.BackColor = Color.FromArgb(202, 196, 183);
            panelCentral.Controls.Add(panelProduto);
            panelCentral.Controls.Add(panelIcone);
            panelCentral.Controls.Add(lblSubtitulo);
            panelCentral.Controls.Add(lblTitulo);
            panelCentral.Location = new Point(41, 12);
            panelCentral.Name = "panelCentral";
            panelCentral.Padding = new Padding(52, 75, 52, 56);
            panelCentral.Size = new Size(962, 531);
            panelCentral.TabIndex = 0;
            // 
            // panelProduto
            // 
            panelProduto.BackColor = Color.FromArgb(202, 196, 183);
            panelProduto.Controls.Add(label1);
            panelProduto.Location = new Point(175, 356);
            panelProduto.Name = "panelProduto";
            panelProduto.Padding = new Padding(26, 28, 26, 28);
            panelProduto.Size = new Size(612, 141);
            panelProduto.TabIndex = 2;
            // 
            // panelIcone
            // 
            panelIcone.BackColor = Color.FromArgb(202, 196, 183);
            panelIcone.Controls.Add(lblIconeCheck);
            panelIcone.Location = new Point(439, 40);
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
            lblSubtitulo.Location = new Point(35, 306);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(858, 47);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Dirija-se ao balcão para retirar seu pedido";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(26, 43, 26);
            lblTitulo.Location = new Point(66, 134);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(804, 182);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SEU PRODUTO ESTÁ PRONTO!";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timerAnimacao
            // 
            timerAnimacao.Enabled = true;
            timerAnimacao.Interval = 1000;
            timerAnimacao.Tick += timerAnimacao_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 64);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // ChamadaGigante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 595);
            Controls.Add(panelPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChamadaGigante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produto Pronto - Cantina";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            panelPrincipal.ResumeLayout(false);
            panelCentral.ResumeLayout(false);
            panelProduto.ResumeLayout(false);
            panelProduto.PerformLayout();
            panelIcone.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelProduto;
        private System.Windows.Forms.Timer timerAnimacao;
        private System.Windows.Forms.Panel panelIcone;
        private System.Windows.Forms.Label lblIconeCheck;
        private Label label1;
    }
}