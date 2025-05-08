namespace cantinaPainel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listAdicionar = new ListBox();
            listPedido = new ListBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            label1 = new Label();
            label2 = new Label();
            total = new Label();
            btnFinalizar = new Button();
            SuspendLayout();
            // 
            // listAdicionar
            // 
            listAdicionar.FormattingEnabled = true;
            listAdicionar.ItemHeight = 15;
            listAdicionar.Location = new Point(78, 177);
            listAdicionar.Name = "listAdicionar";
            listAdicionar.Size = new Size(173, 79);
            listAdicionar.TabIndex = 0;
            listAdicionar.SelectedIndexChanged += listAdicionar_SelectedIndexChanged;
            // 
            // listPedido
            // 
            listPedido.FormattingEnabled = true;
            listPedido.ItemHeight = 15;
            listPedido.Location = new Point(518, 177);
            listPedido.Name = "listPedido";
            listPedido.Size = new Size(173, 79);
            listPedido.TabIndex = 1;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(339, 177);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(99, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(339, 233);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(99, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "< Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 148);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 4;
            label1.Text = "Produtos Cantina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(518, 148);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Carrinho";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Segoe UI", 17F);
            total.Location = new Point(421, 307);
            total.Name = "total";
            total.Size = new Size(82, 31);
            total.TabIndex = 6;
            total.Text = "TOTAL:";
            total.Click += total_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(518, 273);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(173, 23);
            btnFinalizar.TabIndex = 7;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 411);
            Controls.Add(btnFinalizar);
            Controls.Add(total);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listPedido);
            Controls.Add(listAdicionar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listAdicionar;
        private ListBox listPedido;
        private Button btnAdicionar;
        private Button btnRemover;
        private Label label1;
        private Label label2;
        private Label total;
        private Button btnFinalizar;
    }
}
