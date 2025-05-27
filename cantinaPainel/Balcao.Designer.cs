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
            listViewPedidos = new ListView();
            listViewHistorico = new ListView();
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
            // listViewPedidos
            // 
            listViewPedidos.Location = new Point(28, 55);
            listViewPedidos.Name = "listViewPedidos";
            listViewPedidos.Size = new Size(760, 231);
            listViewPedidos.TabIndex = 8;
            listViewPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // listViewHistorico
            // 
            listViewHistorico.Location = new Point(28, 340);
            listViewHistorico.Name = "listViewHistorico";
            listViewHistorico.Size = new Size(760, 196);
            listViewHistorico.TabIndex = 9;
            listViewHistorico.UseCompatibleStateImageBehavior = false;
            listViewHistorico.SelectedIndexChanged += listViewHistorico_SelectedIndexChanged;
            // 
            // formsBalcao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(listViewHistorico);
            Controls.Add(listViewPedidos);
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
        private ListView listViewPedidos;
        private ListView listViewHistorico;
    }
}