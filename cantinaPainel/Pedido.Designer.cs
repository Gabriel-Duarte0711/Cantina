namespace cantinaPainel
{
    partial class formsPedido
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
            btnSair = new Button();
            numericUpDown1 = new NumericUpDown();
            numericQuantidade = new NumericUpDown();
            label3 = new Label();
            btnVoltar = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            txtBoxNome = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
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
            listPedido.SelectedIndexChanged += listPedido_SelectedIndexChanged;
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
            total.Location = new Point(396, 495);
            total.Name = "total";
            total.Size = new Size(82, 31);
            total.TabIndex = 6;
            total.Text = "TOTAL:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(734, 233);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(173, 23);
            btnFinalizar.TabIndex = 7;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(639, 569);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(0, 0);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // numericQuantidade
            // 
            numericQuantidade.Location = new Point(183, 277);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(68, 23);
            numericQuantidade.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(83, 274);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 11;
            label3.Text = "Quantidade:";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(37, 40);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "<";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(396, 569);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(80, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(482, 569);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(80, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // txtBoxNome
            // 
            txtBoxNome.Location = new Point(518, 277);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(173, 23);
            txtBoxNome.TabIndex = 15;
            txtBoxNome.Text = "Nome:";
            txtBoxNome.TextChanged += txtBoxNome_TextChanged;
            // 
            // formsPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1618, 604);
            Controls.Add(txtBoxNome);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnVoltar);
            Controls.Add(label3);
            Controls.Add(numericQuantidade);
            Controls.Add(btnSair);
            Controls.Add(btnFinalizar);
            Controls.Add(total);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(listPedido);
            Controls.Add(listAdicionar);
            Name = "formsPedido";
            Text = "Pedido";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
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
        private Button btnSair;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericQuantidade;
        private Label label3;
        private Button btnVoltar;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TextBox txtBoxNome;
    }
}
