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
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnInformacoes = new System.Windows.Forms.Button();
            this.Img = new System.Windows.Forms.ImageList(this.components);
            this.LblBemVindo = new System.Windows.Forms.Label();
            this.LblOqDeseja = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Location = new System.Drawing.Point(309, 245);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(205, 52);
            this.BtnPesquisa.TabIndex = 0;
            this.BtnPesquisa.Text = "Pesquisa de produtos";
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Location = new System.Drawing.Point(309, 303);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(205, 52);
            this.BtnCadastro.TabIndex = 1;
            this.BtnCadastro.Text = "Cadastro de produtos";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            this.BtnCadastro.Click += new System.EventHandler(this.BtnCadastro_Click);
            // 
            // BtnInformacoes
            // 
            this.BtnInformacoes.Location = new System.Drawing.Point(309, 361);
            this.BtnInformacoes.Name = "BtnInformacoes";
            this.BtnInformacoes.Size = new System.Drawing.Size(205, 52);
            this.BtnInformacoes.TabIndex = 2;
            this.BtnInformacoes.Text = "Informações do Sistema";
            this.BtnInformacoes.UseVisualStyleBackColor = true;
            this.BtnInformacoes.Click += new System.EventHandler(this.BtnInformacoes_Click);
            // 
            // Img
            // 
            this.Img.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Img.ImageStream")));
            this.Img.TransparentColor = System.Drawing.Color.Transparent;
            this.Img.Images.SetKeyName(0, "pokemartexterior.png");
            // 
            // LblBemVindo
            // 
            this.LblBemVindo.AutoSize = true;
            this.LblBemVindo.BackColor = System.Drawing.Color.White;
            this.LblBemVindo.Font = new System.Drawing.Font("Lucida Sans Unicode", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBemVindo.Location = new System.Drawing.Point(192, 157);
            this.LblBemVindo.Name = "LblBemVindo";
            this.LblBemVindo.Size = new System.Drawing.Size(460, 42);
            this.LblBemVindo.TabIndex = 4;
            this.LblBemVindo.Text = "Bem vindo ao Pokemarket!";
            // 
            // LblOqDeseja
            // 
            this.LblOqDeseja.AutoSize = true;
            this.LblOqDeseja.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOqDeseja.Location = new System.Drawing.Point(312, 210);
            this.LblOqDeseja.Name = "LblOqDeseja";
            this.LblOqDeseja.Size = new System.Drawing.Size(199, 32);
            this.LblOqDeseja.TabIndex = 5;
            this.LblOqDeseja.Text = "O que deseja?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::trblh_semestral.Properties.Resources.pokemartexterior;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(344, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 129);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.LblOqDeseja);
            this.Controls.Add(this.LblBemVindo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnInformacoes);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.BtnPesquisa);
            this.Name = "FrmPrincipal";
            this.Text = "Pokemarket - Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button BtnInformacoes;
        private System.Windows.Forms.ImageList Img;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LblBemVindo;
        private System.Windows.Forms.Label LblOqDeseja;
    }
}

