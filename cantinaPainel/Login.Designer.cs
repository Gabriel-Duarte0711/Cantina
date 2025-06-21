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
            txtBoxUsuario = new TextBox();
            txtBoxSenha = new TextBox();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            lblSenha = new Label();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelLogin = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(225, 255, 0);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(17, 25, 12);
            btnLogin.Location = new Point(30, 145);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "⚡ Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.BackColor = Color.FromArgb(243, 241, 238);
            txtBoxUsuario.BorderStyle = BorderStyle.None;
            txtBoxUsuario.Font = new Font("Inter", 12F);
            txtBoxUsuario.ForeColor = Color.FromArgb(17, 25, 12);
            txtBoxUsuario.Location = new Point(30, 50);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(290, 20);
            txtBoxUsuario.TabIndex = 0;
            // 
            // txtBoxSenha
            // 
            txtBoxSenha.BackColor = Color.FromArgb(243, 241, 238);
            txtBoxSenha.BorderStyle = BorderStyle.None;
            txtBoxSenha.Font = new Font("Inter", 12F);
            txtBoxSenha.ForeColor = Color.FromArgb(17, 25, 12);
            txtBoxSenha.Location = new Point(30, 110);
            txtBoxSenha.Name = "txtBoxSenha";
            txtBoxSenha.PasswordChar = '●';
            txtBoxSenha.Size = new Size(290, 20);
            txtBoxSenha.TabIndex = 1;
            txtBoxSenha.TextChanged += txtBoxSenha_TextChanged;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(120, 118, 100);
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Inter", 10F);
            btnSair.ForeColor = Color.FromArgb(243, 241, 238);
            btnSair.Location = new Point(700, 410);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(80, 30);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(300, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Inter", 11F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.FromArgb(243, 241, 238);
            lblUsuario.Location = new Point(30, 25);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 25);
            lblUsuario.TabIndex = 28;
            lblUsuario.Text = "Usuário:";
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSenha
            // 
            lblSenha.Font = new Font("Inter", 11F, FontStyle.Bold);
            lblSenha.ForeColor = Color.FromArgb(243, 241, 238);
            lblSenha.Location = new Point(30, 85);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(80, 25);
            lblSenha.TabIndex = 29;
            lblSenha.Text = "Senha:";
            lblSenha.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(243, 241, 238);
            lblTitulo.Location = new Point(250, 120);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 40);
            lblTitulo.TabIndex = 30;
            lblTitulo.Text = "Acesso Rápido ⚡";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Microsoft Sans Serif", 14F);
            lblSubtitulo.ForeColor = Color.FromArgb(202, 196, 183);
            lblSubtitulo.Location = new Point(200, 160);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(400, 30);
            lblSubtitulo.TabIndex = 31;
            lblSubtitulo.Text = "Entre de forma segura e eficiente";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(120, 118, 100);
            panelLogin.Controls.Add(lblUsuario);
            panelLogin.Controls.Add(txtBoxUsuario);
            panelLogin.Controls.Add(lblSenha);
            panelLogin.Controls.Add(txtBoxSenha);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Location = new Point(225, 220);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(350, 202);
            panelLogin.TabIndex = 32;
            // 
            // formsLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(844, 480);
            Controls.Add(btnSair);
            Controls.Add(panelLogin);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Font = new Font("Inter", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "formsLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bolt - Login";
            Load += formsLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxSenha;
        private Button btnSair;
        private PictureBox pictureBox1;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Panel panelLogin;
    }
}