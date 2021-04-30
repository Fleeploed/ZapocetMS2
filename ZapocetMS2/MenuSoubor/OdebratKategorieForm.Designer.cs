using System.ComponentModel;

namespace ZapocetMS2
{
    partial class OdebratKategorieForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazev = new System.Windows.Forms.TextBox();
            this.buttonOdebrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazev kategorie:";
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(157, 22);
            this.textBoxNazev.Multiline = true;
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(195, 26);
            this.textBoxNazev.TabIndex = 1;
            // 
            // buttonOdebrat
            // 
            this.buttonOdebrat.Location = new System.Drawing.Point(16, 54);
            this.buttonOdebrat.Name = "buttonOdebrat";
            this.buttonOdebrat.Size = new System.Drawing.Size(336, 37);
            this.buttonOdebrat.TabIndex = 2;
            this.buttonOdebrat.Text = "Odebrat";
            this.buttonOdebrat.UseVisualStyleBackColor = true;
            this.buttonOdebrat.Click += new System.EventHandler(this.buttonOdebrat_Click);
            // 
            // OdebratKategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 105);
            this.Controls.Add(this.buttonOdebrat);
            this.Controls.Add(this.textBoxNazev);
            this.Controls.Add(this.label1);
            this.Name = "OdebratKategorieForm";
            this.Text = "Odebrat kategorie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Button buttonOdebrat;

        private System.Windows.Forms.TextBox textBoxNazev;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}