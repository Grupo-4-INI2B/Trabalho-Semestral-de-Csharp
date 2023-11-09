namespace trblh_semestral
{
    partial class FrmPesquisa
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
            this.LblProduto = new System.Windows.Forms.Label();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.LblDisponibilidade = new System.Windows.Forms.Label();
            this.LblValidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtValidade = new System.Windows.Forms.DateTimePicker();
            this.BtnFiltro = new System.Windows.Forms.Button();
            this.DtgPesquisa = new System.Windows.Forms.DataGridView();
            this.TxtProduto = new System.Windows.Forms.TextBox();
            this.TxtDisponibilidade = new System.Windows.Forms.TextBox();
            this.TxtFornecedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblProduto.Location = new System.Drawing.Point(33, 67);
            this.LblProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(89, 13);
            this.LblProduto.TabIndex = 0;
            this.LblProduto.Text = "Nome do produto";
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblFornecedor.Location = new System.Drawing.Point(206, 67);
            this.LblFornecedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(104, 13);
            this.LblFornecedor.TabIndex = 1;
            this.LblFornecedor.Text = "Nome do fornecedor";
            // 
            // LblDisponibilidade
            // 
            this.LblDisponibilidade.AutoSize = true;
            this.LblDisponibilidade.ForeColor = System.Drawing.Color.Black;
            this.LblDisponibilidade.Location = new System.Drawing.Point(372, 67);
            this.LblDisponibilidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDisponibilidade.Name = "LblDisponibilidade";
            this.LblDisponibilidade.Size = new System.Drawing.Size(78, 13);
            this.LblDisponibilidade.TabIndex = 2;
            this.LblDisponibilidade.Text = "Disponibilidade";
            // 
            // LblValidade
            // 
            this.LblValidade.AutoSize = true;
            this.LblValidade.Location = new System.Drawing.Point(215, 124);
            this.LblValidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblValidade.Name = "LblValidade";
            this.LblValidade.Size = new System.Drawing.Size(88, 13);
            this.LblValidade.TabIndex = 3;
            this.LblValidade.Text = "Data de validade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Área de Pesquisa\r\nSelecione os dados para filtrar o resultado da pesquisa ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DtValidade
            // 
            this.DtValidade.Location = new System.Drawing.Point(218, 140);
            this.DtValidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtValidade.Name = "DtValidade";
            this.DtValidade.Size = new System.Drawing.Size(196, 20);
            this.DtValidade.TabIndex = 10;
            // 
            // BtnFiltro
            // 
            this.BtnFiltro.Location = new System.Drawing.Point(446, 124);
            this.BtnFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnFiltro.Name = "BtnFiltro";
            this.BtnFiltro.Size = new System.Drawing.Size(79, 34);
            this.BtnFiltro.TabIndex = 11;
            this.BtnFiltro.Text = "Filtrar";
            this.BtnFiltro.UseVisualStyleBackColor = true;
            this.BtnFiltro.Click += new System.EventHandler(this.BtnFiltro_Click);
            // 
            // DtgPesquisa
            // 
            this.DtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPesquisa.Location = new System.Drawing.Point(35, 210);
            this.DtgPesquisa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtgPesquisa.Name = "DtgPesquisa";
            this.DtgPesquisa.RowHeadersWidth = 51;
            this.DtgPesquisa.RowTemplate.Height = 24;
            this.DtgPesquisa.Size = new System.Drawing.Size(489, 122);
            this.DtgPesquisa.TabIndex = 12;
            // 
            // TxtProduto
            // 
            this.TxtProduto.Location = new System.Drawing.Point(34, 82);
            this.TxtProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtProduto.Name = "TxtProduto";
            this.TxtProduto.Size = new System.Drawing.Size(116, 20);
            this.TxtProduto.TabIndex = 13;
            // 
            // TxtDisponibilidade
            // 
            this.TxtDisponibilidade.Location = new System.Drawing.Point(374, 82);
            this.TxtDisponibilidade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDisponibilidade.Name = "TxtDisponibilidade";
            this.TxtDisponibilidade.Size = new System.Drawing.Size(96, 20);
            this.TxtDisponibilidade.TabIndex = 14;
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.Location = new System.Drawing.Point(209, 82);
            this.TxtFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Size = new System.Drawing.Size(111, 20);
            this.TxtFornecedor.TabIndex = 15;
            // 
            // FrmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(this.TxtDisponibilidade);
            this.Controls.Add(this.TxtProduto);
            this.Controls.Add(this.DtgPesquisa);
            this.Controls.Add(this.BtnFiltro);
            this.Controls.Add(this.DtValidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblProduto);
            this.Controls.Add(this.LblValidade);
            this.Controls.Add(this.LblDisponibilidade);
            this.Controls.Add(this.LblFornecedor);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPesquisa";
            this.Text = "Pesquisa de produtos";
            this.Load += new System.EventHandler(this.FrmPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.Label LblDisponibilidade;
        private System.Windows.Forms.Label LblValidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFiltro;
        private System.Windows.Forms.DateTimePicker DtValidade;
        private System.Windows.Forms.DataGridView DtgPesquisa;
        private System.Windows.Forms.TextBox TxtProduto;
        private System.Windows.Forms.TextBox TxtDisponibilidade;
        private System.Windows.Forms.TextBox TxtFornecedor;
    }
}