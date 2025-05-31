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
            label4 = new Label();
            comboBoxPagamento = new ComboBox();
            label5 = new Label();
            numericTroco = new NumericUpDown();
            label6 = new Label();
            txtBoxTroco = new TextBox();
            label7 = new Label();
            btnTroco = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericTroco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listAdicionar
            // 
            listAdicionar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listAdicionar.FormattingEnabled = true;
            listAdicionar.ItemHeight = 15;
            listAdicionar.Location = new Point(78, 177);
            listAdicionar.Name = "listAdicionar";
            listAdicionar.Size = new Size(214, 94);
            listAdicionar.TabIndex = 0;
            listAdicionar.SelectedIndexChanged += listAdicionar_SelectedIndexChanged;
            // 
            // listPedido
            // 
            listPedido.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listPedido.FormattingEnabled = true;
            listPedido.ItemHeight = 15;
            listPedido.Location = new Point(518, 174);
            listPedido.Name = "listPedido";
            listPedido.Size = new Size(214, 94);
            listPedido.TabIndex = 1;
            listPedido.SelectedIndexChanged += listPedido_SelectedIndexChanged;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(17, 25, 12);
            btnAdicionar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.FromArgb(230, 255, 0);
            btnAdicionar.Location = new Point(339, 177);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(99, 23);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar >";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(17, 25, 12);
            btnRemover.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.FromArgb(230, 255, 0);
            btnRemover.Location = new Point(339, 233);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(99, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "< Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 148);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 4;
            label1.Text = "Produtos Cantina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(515, 148);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "Carrinho";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Microsoft Sans Serif", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            total.ForeColor = Color.White;
            total.Location = new Point(396, 495);
            total.Name = "total";
            total.Size = new Size(104, 29);
            total.TabIndex = 6;
            total.Text = "TOTAL:";
            // 
            // btnFinalizar
            // 
            btnFinalizar.BackColor = Color.FromArgb(17, 25, 12);
            btnFinalizar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFinalizar.ForeColor = Color.FromArgb(230, 255, 0);
            btnFinalizar.Location = new Point(596, 435);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(136, 28);
            btnFinalizar.TabIndex = 7;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = false;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(17, 25, 12);
            btnSair.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.ForeColor = Color.FromArgb(230, 255, 0);
            btnSair.Location = new Point(657, 570);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
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
            numericQuantidade.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericQuantidade.Location = new Point(191, 277);
            numericQuantidade.Name = "numericQuantidade";
            numericQuantidade.Size = new Size(101, 21);
            numericQuantidade.TabIndex = 10;
            numericQuantidade.ValueChanged += numericQuantidade_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(17, 25, 12);
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(243, 241, 238);
            label3.Location = new Point(78, 278);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 11;
            label3.Text = "Quantidade:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.FromArgb(17, 25, 12);
            btnVoltar.ForeColor = Color.FromArgb(230, 255, 0);
            btnVoltar.Location = new Point(12, 12);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(37, 40);
            btnVoltar.TabIndex = 12;
            btnVoltar.Text = "<";
            btnVoltar.UseVisualStyleBackColor = false;
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
            txtBoxNome.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxNome.Location = new Point(596, 274);
            txtBoxNome.Name = "txtBoxNome";
            txtBoxNome.Size = new Size(136, 21);
            txtBoxNome.TabIndex = 15;
            txtBoxNome.Tag = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(518, 275);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 17;
            label4.Text = "Nome:";
            // 
            // comboBoxPagamento
            // 
            comboBoxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPagamento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxPagamento.FormattingEnabled = true;
            comboBoxPagamento.Location = new Point(596, 312);
            comboBoxPagamento.Name = "comboBoxPagamento";
            comboBoxPagamento.Size = new Size(136, 23);
            comboBoxPagamento.TabIndex = 18;
            comboBoxPagamento.SelectedIndexChanged += comboBoxPagamento_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(518, 312);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 19;
            label5.Text = "Método:";
            // 
            // numericTroco
            // 
            numericTroco.DecimalPlaces = 2;
            numericTroco.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericTroco.Location = new Point(596, 345);
            numericTroco.Name = "numericTroco";
            numericTroco.Size = new Size(136, 21);
            numericTroco.TabIndex = 20;
            numericTroco.ValueChanged += numericTroco_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(518, 345);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 21;
            label6.Text = "Valor:";
            // 
            // txtBoxTroco
            // 
            txtBoxTroco.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTroco.Location = new Point(596, 408);
            txtBoxTroco.Name = "txtBoxTroco";
            txtBoxTroco.Size = new Size(136, 21);
            txtBoxTroco.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(518, 409);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 23;
            label7.Text = "Troco:";
            // 
            // btnTroco
            // 
            btnTroco.BackColor = Color.FromArgb(17, 25, 12);
            btnTroco.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTroco.ForeColor = Color.FromArgb(230, 255, 0);
            btnTroco.Location = new Point(596, 379);
            btnTroco.Name = "btnTroco";
            btnTroco.Size = new Size(136, 23);
            btnTroco.TabIndex = 24;
            btnTroco.Text = "Troco";
            btnTroco.UseVisualStyleBackColor = false;
            btnTroco.Click += btnTroco_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(17, 25, 12);
            button1.ForeColor = Color.FromArgb(230, 255, 0);
            button1.Location = new Point(1111, 413);
            button1.Name = "button1";
            button1.Size = new Size(85, 31);
            button1.TabIndex = 25;
            button1.Text = "balcao";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.imagem_2025_05_15_081300623;
            pictureBox1.Location = new Point(55, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(596, 479);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Viagem";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(1109, 356);
            button2.Name = "button2";
            button2.Size = new Size(87, 33);
            button2.TabIndex = 28;
            button2.Text = "Cozinha";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1109, 299);
            button3.Name = "button3";
            button3.Size = new Size(87, 33);
            button3.TabIndex = 29;
            button3.Text = "Chamada";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // formsPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 25, 12);
            ClientSize = new Size(1290, 604);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(btnTroco);
            Controls.Add(label7);
            Controls.Add(txtBoxTroco);
            Controls.Add(label6);
            Controls.Add(numericTroco);
            Controls.Add(label5);
            Controls.Add(comboBoxPagamento);
            Controls.Add(label4);
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
            Text = "v bc";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericTroco).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label4;
        private ComboBox comboBoxPagamento;
        private Label label5;
        private NumericUpDown numericTroco;
        private Label label6;
        private TextBox txtBoxTroco;
        private Label label7;
        private Button btnTroco;
        private Button button1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
    }
}
