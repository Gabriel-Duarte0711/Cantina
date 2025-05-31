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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxNomePreparando
            // 
            listBoxNomePreparando.FormattingEnabled = true;
            listBoxNomePreparando.ItemHeight = 15;
            listBoxNomePreparando.Location = new Point(115, 115);
            listBoxNomePreparando.Name = "listBoxNomePreparando";
            listBoxNomePreparando.Size = new Size(177, 319);
            listBoxNomePreparando.TabIndex = 0;
            // 
            // listBoxNomePronto
            // 
            listBoxNomePronto.FormattingEnabled = true;
            listBoxNomePronto.ItemHeight = 15;
            listBoxNomePronto.Location = new Point(430, 115);
            listBoxNomePronto.Name = "listBoxNomePronto";
            listBoxNomePronto.Size = new Size(177, 319);
            listBoxNomePronto.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(47, 44);
            button1.TabIndex = 2;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(88, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(453, 75);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 29;
            label3.Text = "PRONTO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(106, 75);
            label4.Name = "label4";
            label4.Size = new Size(198, 37);
            label4.TabIndex = 30;
            label4.Text = "PREPARANDO";
            // 
            // formsTela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(listBoxNomePronto);
            Controls.Add(listBoxNomePreparando);
            Name = "formsTela";
            Text = "tela";
            Load += formsTela_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxNomePreparando;
        private ListBox listBoxNomePronto;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
    }
}