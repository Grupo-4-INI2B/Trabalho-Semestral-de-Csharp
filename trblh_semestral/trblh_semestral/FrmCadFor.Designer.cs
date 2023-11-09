namespace trblh_semestral
{
    partial class FrmCadFor
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
            this.LblAreaCad = new System.Windows.Forms.Label();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblEndereco = new System.Windows.Forms.Label();
            this.TxtFornecedor = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTelefone = new System.Windows.Forms.TextBox();
            this.TxtEndereco = new System.Windows.Forms.TextBox();
            this.BtnBusca = new System.Windows.Forms.Button();
            this.TxtBusca = new System.Windows.Forms.TextBox();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.DtgFornecedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAreaCad
            // 
            this.LblAreaCad.AutoSize = true;
            this.LblAreaCad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblAreaCad.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAreaCad.Location = new System.Drawing.Point(183, 24);
            this.LblAreaCad.Name = "LblAreaCad";
            this.LblAreaCad.Size = new System.Drawing.Size(442, 30);
            this.LblAreaCad.TabIndex = 0;
            this.LblAreaCad.Text = "Área de Cadastro de Fornecedores:";
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFornecedor.Location = new System.Drawing.Point(122, 85);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(60, 22);
            this.LblFornecedor.TabIndex = 1;
            this.LblFornecedor.Text = "Nome:";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefone.Location = new System.Drawing.Point(405, 85);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(100, 22);
            this.LblTelefone.TabIndex = 3;
            this.LblTelefone.Text = "Telefone:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(122, 124);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(80, 22);
            this.LblEmail.TabIndex = 4;
            this.LblEmail.Text = "E-mail:";
            this.LblEmail.Click += new System.EventHandler(this.label4_Click);
            // 
            // LblEndereco
            // 
            this.LblEndereco.AutoSize = true;
            this.LblEndereco.Font = new System.Drawing.Font("Cascadia Mono", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndereco.Location = new System.Drawing.Point(405, 124);
            this.LblEndereco.Name = "LblEndereco";
            this.LblEndereco.Size = new System.Drawing.Size(100, 22);
            this.LblEndereco.TabIndex = 5;
            this.LblEndereco.Text = "Endereço:";
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.Location = new System.Drawing.Point(188, 85);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Size = new System.Drawing.Size(197, 22);
            this.TxtFornecedor.TabIndex = 6;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(207, 124);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(178, 22);
            this.TxtEmail.TabIndex = 7;
            // 
            // TxtTelefone
            // 
            this.TxtTelefone.Location = new System.Drawing.Point(511, 83);
            this.TxtTelefone.Name = "TxtTelefone";
            this.TxtTelefone.Size = new System.Drawing.Size(177, 22);
            this.TxtTelefone.TabIndex = 9;
            // 
            // TxtEndereco
            // 
            this.TxtEndereco.Location = new System.Drawing.Point(511, 124);
            this.TxtEndereco.Name = "TxtEndereco";
            this.TxtEndereco.Size = new System.Drawing.Size(177, 22);
            this.TxtEndereco.TabIndex = 10;
            // 
            // BtnBusca
            // 
            this.BtnBusca.Location = new System.Drawing.Point(221, 258);
            this.BtnBusca.Name = "BtnBusca";
            this.BtnBusca.Size = new System.Drawing.Size(75, 23);
            this.BtnBusca.TabIndex = 32;
            this.BtnBusca.Text = "Busca";
            this.BtnBusca.UseVisualStyleBackColor = true;
            this.BtnBusca.Click += new System.EventHandler(this.BtnBusca_Click);
            // 
            // TxtBusca
            // 
            this.TxtBusca.Location = new System.Drawing.Point(50, 260);
            this.TxtBusca.Name = "TxtBusca";
            this.TxtBusca.Size = new System.Drawing.Size(165, 22);
            this.TxtBusca.TabIndex = 31;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(443, 258);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 30;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(351, 258);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 29;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(443, 177);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 28;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Location = new System.Drawing.Point(255, 177);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(97, 23);
            this.BtnCadastro.TabIndex = 27;
            this.BtnCadastro.Text = "Cadastrar";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // DtgFornecedor
            // 
            this.DtgFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFornecedor.Location = new System.Drawing.Point(50, 288);
            this.DtgFornecedor.Name = "DtgFornecedor";
            this.DtgFornecedor.RowHeadersWidth = 51;
            this.DtgFornecedor.RowTemplate.Height = 24;
            this.DtgFornecedor.Size = new System.Drawing.Size(708, 150);
            this.DtgFornecedor.TabIndex = 26;
            this.DtgFornecedor.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgFornecedor_RowHeaderMouseDoubleClick);
            // 
            // FrmCadFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBusca);
            this.Controls.Add(this.TxtBusca);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.DtgFornecedor);
            this.Controls.Add(this.TxtEndereco);
            this.Controls.Add(this.TxtTelefone);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(this.LblEndereco);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblFornecedor);
            this.Controls.Add(this.LblAreaCad);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadFor";
            this.Text = "Cadastro e Pesquisa Fornecedores";
            this.Load += new System.EventHandler(this.FrmCadFor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAreaCad;
        private System.Windows.Forms.Label LblFornecedor;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblEndereco;
        private System.Windows.Forms.TextBox TxtFornecedor;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtTelefone;
        private System.Windows.Forms.TextBox TxtEndereco;
        private System.Windows.Forms.Button BtnBusca;
        private System.Windows.Forms.TextBox TxtBusca;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.DataGridView DtgFornecedor;
    }
}