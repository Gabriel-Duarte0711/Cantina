namespace cantinaPainel
{
    partial class tela
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
            listBoxPreparando = new ListBox();
            SuspendLayout();
            // 
            // listBoxPreparando
            // 
            listBoxPreparando.FormattingEnabled = true;
            listBoxPreparando.ItemHeight = 15;
            listBoxPreparando.Location = new Point(115, 70);
            listBoxPreparando.Name = "listBoxPreparando";
            listBoxPreparando.Size = new Size(139, 304);
            listBoxPreparando.TabIndex = 0;
            // 
            // tela
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPreparando);
            Name = "tela";
            Text = "tela";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxPreparando;
    }
}