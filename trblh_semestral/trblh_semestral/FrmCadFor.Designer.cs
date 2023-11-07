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
            this.SuspendLayout();
            // 
            // LblAreaCad
            // 
            this.LblAreaCad.AutoSize = true;
            this.LblAreaCad.Location = new System.Drawing.Point(13, 13);
            this.LblAreaCad.Name = "LblAreaCad";
            this.LblAreaCad.Size = new System.Drawing.Size(220, 16);
            this.LblAreaCad.TabIndex = 0;
            this.LblAreaCad.Text = "Área de Cadastro de Fornecedores";
            // 
            // FrmCadFor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAreaCad);
            this.Name = "FrmCadFor";
            this.Text = "Cadastro Fornecedores";
            this.Load += new System.EventHandler(this.FrmCadFor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAreaCad;
    }
}