using System.ComponentModel;

namespace ZapocetMS2
{
    partial class PridatKategorieForm
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
            this.buttonPridat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Název kategorie:";
            // 
            // textBoxNazev
            // 
            this.textBoxNazev.Location = new System.Drawing.Point(157, 22);
            this.textBoxNazev.Multiline = true;
            this.textBoxNazev.Name = "textBoxNazev";
            this.textBoxNazev.Size = new System.Drawing.Size(195, 26);
            this.textBoxNazev.TabIndex = 1;
            // 
            // buttonPridat
            // 
            this.buttonPridat.Location = new System.Drawing.Point(16, 54);
            this.buttonPridat.Name = "buttonPridat";
            this.buttonPridat.Size = new System.Drawing.Size(336, 37);
            this.buttonPridat.TabIndex = 2;
            this.buttonPridat.Text = "Přidat";
            this.buttonPridat.UseVisualStyleBackColor = true;
            this.buttonPridat.Click += new System.EventHandler(this.buttonPridat_Click);
            // 
            // PridatKategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 103);
            this.Controls.Add(this.buttonPridat);
            this.Controls.Add(this.textBoxNazev);
            this.Controls.Add(this.label1);
            this.Name = "PridatKategorieForm";
            this.Text = "Přidat kategorie";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonPridat;

        private System.Windows.Forms.TextBox textBoxNazev;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}