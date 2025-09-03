namespace AppMVC.View
{
    partial class ProdutoView
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
            dgvProdutos = new DataGridView();
            txtId = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdicionar = new Button();
            btnRemover = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(8, 139);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.ReadOnly = true;
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(780, 252);
            dgvProdutos.TabIndex = 6;
            dgvProdutos.TabStop = false;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 14F);
            txtId.Location = new Point(124, 15);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 32);
            txtId.TabIndex = 1;
            txtId.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14F);
            txtNome.Location = new Point(388, 15);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(400, 32);
            txtNome.TabIndex = 0;
            // 
            // txtPreco
            // 
            txtPreco.Font = new Font("Segoe UI", 14F);
            txtPreco.Location = new Point(124, 74);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 32);
            txtPreco.TabIndex = 1;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Font = new Font("Segoe UI", 14F);
            txtQuantidade.Location = new Point(388, 74);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 32);
            txtQuantidade.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 2;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(301, 25);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(18, 81);
            label3.Name = "label3";
            label3.Size = new Size(64, 25);
            label3.TabIndex = 2;
            label3.Text = "Preço:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(253, 81);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 2;
            label4.Text = "Quantidade:";
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 14F);
            btnAdicionar.Location = new Point(9, 421);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(126, 39);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Segoe UI", 14F);
            btnRemover.Location = new Point(185, 421);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(126, 39);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // ProdutoView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 472);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtId);
            Controls.Add(dgvProdutos);
            Name = "ProdutoView";
            Text = "ProdutoView";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private TextBox txtId;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdicionar;
        private Button btnRemover;
    }
}