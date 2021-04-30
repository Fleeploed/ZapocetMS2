namespace ZapocetMS2
{
    partial class IndexForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.Windows.Forms.Button pocetPotraviny;
            System.Windows.Forms.Button menuButton;
            System.Windows.Forms.Button buttonJidlo;
            pocetPotraviny = new System.Windows.Forms.Button();
            menuButton = new System.Windows.Forms.Button();
            buttonJidlo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pocetPotraviny
            // 
            pocetPotraviny.Location = new System.Drawing.Point(12, 12);
            pocetPotraviny.Name = "pocetPotraviny";
            pocetPotraviny.Size = new System.Drawing.Size(274, 45);
            pocetPotraviny.TabIndex = 0;
            pocetPotraviny.Text = "Počet potraviny";
            pocetPotraviny.UseVisualStyleBackColor = true;
            pocetPotraviny.Click += new System.EventHandler(this.pocetPotraviny_Click);
            // 
            // menuButton
            // 
            menuButton.AllowDrop = true;
            menuButton.Location = new System.Drawing.Point(12, 63);
            menuButton.Name = "menuButton";
            menuButton.Size = new System.Drawing.Size(274, 45);
            menuButton.TabIndex = 1;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonJidlo
            // 
            buttonJidlo.AllowDrop = true;
            buttonJidlo.Location = new System.Drawing.Point(12, 114);
            buttonJidlo.Name = "buttonJidlo";
            buttonJidlo.Size = new System.Drawing.Size(274, 45);
            buttonJidlo.TabIndex = 2;
            buttonJidlo.Text = "Jídlo";
            buttonJidlo.UseVisualStyleBackColor = true;
            buttonJidlo.Click += new System.EventHandler(this.buttonJidlo_Click);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 177);
            this.Controls.Add(buttonJidlo);
            this.Controls.Add(menuButton);
            this.Controls.Add(pocetPotraviny);
            this.Name = "IndexForm";
            this.Text = "Index";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button pocetPotraviny;

        #endregion
    }
}