namespace cantinaPainel
{
    partial class formsLogin
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
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(362, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(163, 29);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 160);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 198);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Senha";
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(239, 157);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(286, 23);
            txtBoxUsuario.TabIndex = 0;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.Location = new Point(239, 195);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.Size = new Size(286, 23);
            txtBoxSenha.TabIndex = 1;
            txtBoxSenha.TextChanged += txtBoxSenha_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(660, 388);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(77, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // formsLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtBoxSenha);
            Controls.Add(txtBoxUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Name = "formsLogin";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private Button button1;
        private PictureBox pictureBox1;
    }
}