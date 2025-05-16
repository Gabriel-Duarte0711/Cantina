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
            label1 = new Label();
            btnEntregar = new Button();
            listBox1 = new ListBox();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "balcao";
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(542, 362);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(75, 23);
            btnEntregar.TabIndex = 1;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(438, 73);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(286, 274);
            listBox1.TabIndex = 4;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 9);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(39, 40);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "<";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // formsBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(listBox1);
            Controls.Add(btnEntregar);
            Controls.Add(label1);
            Name = "formsBalcao";
            Text = "formsBalcao";
            Load += formsBalcao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnEntregar;
        private ListBox listBox1;
        private Button btnVoltar;
    }
}