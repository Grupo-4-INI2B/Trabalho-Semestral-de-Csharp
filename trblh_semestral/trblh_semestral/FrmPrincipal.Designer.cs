namespace trblh_semestral
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnCadFor = new System.Windows.Forms.Button();
            this.BtnInformacoes = new System.Windows.Forms.Button();
            this.Img = new System.Windows.Forms.ImageList(this.components);
            this.LblBemVindo = new System.Windows.Forms.Label();
            this.LblOqDeseja = new System.Windows.Forms.Label();
            this.BtnCadProd = new System.Windows.Forms.Button();
            this.PicPokemarket = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicPokemarket)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Location = new System.Drawing.Point(344, 234);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(140, 49);
            this.BtnPesquisa.TabIndex = 0;
            this.BtnPesquisa.Text = "Pesquisa de produtos";
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // BtnCadFor
            // 
            this.BtnCadFor.Location = new System.Drawing.Point(344, 344);
            this.BtnCadFor.Name = "BtnCadFor";
            this.BtnCadFor.Size = new System.Drawing.Size(140, 49);
            this.BtnCadFor.TabIndex = 1;
            this.BtnCadFor.Text = "Cadastro de fornecedor";
            this.BtnCadFor.UseVisualStyleBackColor = true;
            this.BtnCadFor.Click += new System.EventHandler(this.BtnCadFor_Click);
            // 
            // BtnInformacoes
            // 
            this.BtnInformacoes.Location = new System.Drawing.Point(344, 399);
            this.BtnInformacoes.Name = "BtnInformacoes";
            this.BtnInformacoes.Size = new System.Drawing.Size(140, 49);
            this.BtnInformacoes.TabIndex = 2;
            this.BtnInformacoes.Text = "Informações do Sistema";
            this.BtnInformacoes.UseVisualStyleBackColor = true;
            this.BtnInformacoes.Click += new System.EventHandler(this.BtnInformacoes_Click);
            // 
            // Img
            // 
            this.Img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img.ImageStream")));
            this.Img.TransparentColor = System.Drawing.Color.Transparent;
            this.Img.Images.SetKeyName(0, "");
            // 
            // LblBemVindo
            // 
            this.LblBemVindo.AutoSize = true;
            this.LblBemVindo.BackColor = System.Drawing.Color.White;
            this.LblBemVindo.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBemVindo.Location = new System.Drawing.Point(192, 157);
            this.LblBemVindo.Name = "LblBemVindo";
            this.LblBemVindo.Size = new System.Drawing.Size(438, 40);
            this.LblBemVindo.TabIndex = 4;
            this.LblBemVindo.Text = "Bem vindo ao Pokemarket!";
            // 
            // LblOqDeseja
            // 
            this.LblOqDeseja.AutoSize = true;
            this.LblOqDeseja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOqDeseja.Location = new System.Drawing.Point(319, 199);
            this.LblOqDeseja.Name = "LblOqDeseja";
            this.LblOqDeseja.Size = new System.Drawing.Size(199, 32);
            this.LblOqDeseja.TabIndex = 5;
            this.LblOqDeseja.Text = "O que deseja?";
            this.LblOqDeseja.Click += new System.EventHandler(this.LblOqDeseja_Click);
            // 
            // BtnCadProd
            // 
            this.BtnCadProd.Location = new System.Drawing.Point(344, 289);
            this.BtnCadProd.Name = "BtnCadProd";
            this.BtnCadProd.Size = new System.Drawing.Size(140, 49);
            this.BtnCadProd.TabIndex = 6;
            this.BtnCadProd.Text = "Cadastro de produtos";
            this.BtnCadProd.UseVisualStyleBackColor = true;
            this.BtnCadProd.Click += new System.EventHandler(this.BtnCadProd_Click);
            // 
            // PicPokemarket
            // 
            this.PicPokemarket.BackgroundImage = global::trblh_semestral.Properties.Resources.pokemartexterior;
            this.PicPokemarket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicPokemarket.Location = new System.Drawing.Point(325, -3);
            this.PicPokemarket.Name = "PicPokemarket";
            this.PicPokemarket.Size = new System.Drawing.Size(174, 157);
            this.PicPokemarket.TabIndex = 3;
            this.PicPokemarket.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.BtnCadProd);
            this.Controls.Add(this.LblOqDeseja);
            this.Controls.Add(this.LblBemVindo);
            this.Controls.Add(this.PicPokemarket);
            this.Controls.Add(this.BtnInformacoes);
            this.Controls.Add(this.BtnCadFor);
            this.Controls.Add(this.BtnPesquisa);
            this.Name = "FrmPrincipal";
            this.Text = "Pokemarket - Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicPokemarket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnCadFor;
        private System.Windows.Forms.Button BtnInformacoes;
        private System.Windows.Forms.ImageList Img;
        private System.Windows.Forms.Label LblBemVindo;
        private System.Windows.Forms.Label LblOqDeseja;
        private System.Windows.Forms.Button BtnCadProd;
        private System.Windows.Forms.PictureBox PicPokemarket;
    }
}

