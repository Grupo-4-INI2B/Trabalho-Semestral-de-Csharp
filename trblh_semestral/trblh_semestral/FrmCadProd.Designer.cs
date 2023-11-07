namespace trblh_semestral
{
    partial class FrmCadProd
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
            this.LblAreaCadProd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblAreaCadProd
            // 
            this.LblAreaCadProd.AutoSize = true;
            this.LblAreaCadProd.Location = new System.Drawing.Point(13, 13);
            this.LblAreaCadProd.Name = "LblAreaCadProd";
            this.LblAreaCadProd.Size = new System.Drawing.Size(44, 16);
            this.LblAreaCadProd.TabIndex = 0;
            this.LblAreaCadProd.Text = "label1";
            // 
            // FrmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAreaCadProd);
            this.Name = "FrmCadProd";
            this.Text = "FrmCadProd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAreaCadProd;
    }
}