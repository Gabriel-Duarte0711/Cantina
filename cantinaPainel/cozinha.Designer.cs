namespace cantinaPainel
{
    partial class formsCozinha
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
            listBoxChapa = new ListBox();
            button1 = new Button();
            btnFeito = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxChapa
            // 
            listBoxChapa.FormattingEnabled = true;
            listBoxChapa.ItemHeight = 15;
            listBoxChapa.Location = new Point(68, 116);
            listBoxChapa.Name = "listBoxChapa";
            listBoxChapa.Size = new Size(1486, 454);
            listBoxChapa.TabIndex = 0;
            listBoxChapa.SelectedIndexChanged += listBoxChapa_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 25, 12);
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.FromArgb(230, 255, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(45, 50);
            button1.TabIndex = 1;
            button1.Text = "<";
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnFeito
            // 
            btnFeito.BackColor = Color.FromArgb(17, 25, 12);
            btnFeito.ForeColor = Color.FromArgb(230, 255, 0);
            btnFeito.Location = new Point(68, 576);
            btnFeito.Name = "btnFeito";
            btnFeito.Size = new Size(1486, 57);
            btnFeito.TabIndex = 2;
            btnFeito.Text = "Feito";
            btnFeito.UseVisualStyleBackColor = false;
            btnFeito.Click += btnFeito_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(251, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1194, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 29;
            label1.Text = "Cozinha";
            // 
            // formsCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1613, 645);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnFeito);
            Controls.Add(button1);
            Controls.Add(listBoxChapa);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "formsCozinha";
            Text = "cozinha";
            Load += formsCozinha_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBoxChapa;
        private Button button1;
        private Button btnFeito;
        private PictureBox pictureBox1;
    }
}