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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnEntregar = new Button();
            btnVoltar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listBoxPedidos = new ListBox();
            listBoxHistorico = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(108, 11);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 0;
            label1.Text = "balcao";
            // 
            // btnEntregar
            // 
            btnEntregar.Location = new Point(662, 292);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(126, 40);
            btnEntregar.TabIndex = 1;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = true;
            btnEntregar.Click += btnEntregar_Click;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listBoxPedidos
            // 
            listBoxPedidos.FormattingEnabled = true;
            listBoxPedidos.ItemHeight = 15;
            listBoxPedidos.Location = new Point(161, 77);
            listBoxPedidos.Name = "listBoxPedidos";
            listBoxPedidos.Size = new Size(561, 169);
            listBoxPedidos.TabIndex = 6;
            // 
            // listBoxHistorico
            // 
            listBoxHistorico.FormattingEnabled = true;
            listBoxHistorico.ItemHeight = 15;
            listBoxHistorico.Location = new Point(108, 338);
            listBoxHistorico.Name = "listBoxHistorico";
            listBoxHistorico.Size = new Size(561, 169);
            listBoxHistorico.TabIndex = 7;
            listBoxHistorico.SelectedIndexChanged += listBoxHistorico_SelectedIndexChanged;
            // 
            // formsBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(listBoxHistorico);
            Controls.Add(listBoxPedidos);
            Controls.Add(btnVoltar);
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
        private Button btnVoltar;
        private ContextMenuStrip contextMenuStrip1;
        private ListBox listBoxPedidos;
        private ListBox listBoxHistorico;
    }
}