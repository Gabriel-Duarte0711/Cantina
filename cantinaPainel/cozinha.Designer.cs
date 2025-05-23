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
            SuspendLayout();
            // 
            // listBoxChapa
            // 
            listBoxChapa.FormattingEnabled = true;
            listBoxChapa.ItemHeight = 15;
            listBoxChapa.Location = new Point(30, 53);
            listBoxChapa.Name = "listBoxChapa";
            listBoxChapa.Size = new Size(484, 334);
            listBoxChapa.TabIndex = 0;
            listBoxChapa.SelectedIndexChanged += listBoxChapa_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(41, 35);
            button1.TabIndex = 1;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnFeito
            // 
            btnFeito.Location = new Point(607, 108);
            btnFeito.Name = "btnFeito";
            btnFeito.Size = new Size(75, 23);
            btnFeito.TabIndex = 2;
            btnFeito.Text = "Feito";
            btnFeito.UseVisualStyleBackColor = true;
            btnFeito.Click += btnFeito_Click;
            // 
            // formsCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFeito);
            Controls.Add(button1);
            Controls.Add(listBoxChapa);
            Name = "formsCozinha";
            Text = "cozinha";
            Load += formsCozinha_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox listBoxChapa;
        private Button button1;
        private Button btnFeito;
    }
}