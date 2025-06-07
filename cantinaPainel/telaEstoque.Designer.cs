namespace cantinaPainel
{
    partial class formsEstoque
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
            listBoxEstoque = new ListBox();
            SuspendLayout();
            // 
            // listBoxEstoque
            // 
            listBoxEstoque.FormattingEnabled = true;
            listBoxEstoque.ItemHeight = 15;
            listBoxEstoque.Location = new Point(108, 47);
            listBoxEstoque.Name = "listBoxEstoque";
            listBoxEstoque.Size = new Size(506, 334);
            listBoxEstoque.TabIndex = 0;
            // 
            // formsEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxEstoque);
            Name = "formsEstoque";
            Text = "telaEstoque";
            Load += telaEstoque_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxEstoque;
    }
}