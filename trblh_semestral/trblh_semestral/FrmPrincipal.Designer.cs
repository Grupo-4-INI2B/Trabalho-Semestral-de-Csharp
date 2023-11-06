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
            this.BtnPesquisa = new System.Windows.Forms.Button();
            this.BtnCadastro = new System.Windows.Forms.Button();
            this.BtnInformacoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPesquisa
            // 
            this.BtnPesquisa.Location = new System.Drawing.Point(334, 232);
            this.BtnPesquisa.Name = "BtnPesquisa";
            this.BtnPesquisa.Size = new System.Drawing.Size(205, 52);
            this.BtnPesquisa.TabIndex = 0;
            this.BtnPesquisa.Text = "Pesquisa";
            this.BtnPesquisa.UseVisualStyleBackColor = true;
            this.BtnPesquisa.Click += new System.EventHandler(this.BtnPesquisa_Click);
            // 
            // BtnCadastro
            // 
            this.BtnCadastro.Location = new System.Drawing.Point(334, 290);
            this.BtnCadastro.Name = "BtnCadastro";
            this.BtnCadastro.Size = new System.Drawing.Size(205, 52);
            this.BtnCadastro.TabIndex = 1;
            this.BtnCadastro.Text = "Cadastro";
            this.BtnCadastro.UseVisualStyleBackColor = true;
            // 
            // BtnInformacoes
            // 
            this.BtnInformacoes.Location = new System.Drawing.Point(334, 348);
            this.BtnInformacoes.Name = "BtnInformacoes";
            this.BtnInformacoes.Size = new System.Drawing.Size(205, 52);
            this.BtnInformacoes.TabIndex = 2;
            this.BtnInformacoes.Text = "Informações do Sistema";
            this.BtnInformacoes.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.BtnInformacoes);
            this.Controls.Add(this.BtnCadastro);
            this.Controls.Add(this.BtnPesquisa);
            this.Name = "FrmPrincipal";
            this.Text = "Pokemarket - Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnPesquisa;
        private System.Windows.Forms.Button BtnCadastro;
        private System.Windows.Forms.Button BtnInformacoes;
    }
}

