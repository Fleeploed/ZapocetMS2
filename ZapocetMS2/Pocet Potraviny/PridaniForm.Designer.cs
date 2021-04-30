using System.ComponentModel;

namespace ZapocetMS2
{
    partial class PridaniForm
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
            this.pocetPridani = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nazevPridani = new System.Windows.Forms.TextBox();
            this.buttonPridani = new System.Windows.Forms.Button();
            this.comboBoxJednotka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Název:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pocetPridani
            // 
            this.pocetPridani.Location = new System.Drawing.Point(106, 82);
            this.pocetPridani.Multiline = true;
            this.pocetPridani.Name = "pocetPridani";
            this.pocetPridani.Size = new System.Drawing.Size(70, 23);
            this.pocetPridani.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Počet:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jednotka:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nazevPridani
            // 
            this.nazevPridani.Location = new System.Drawing.Point(106, 15);
            this.nazevPridani.Multiline = true;
            this.nazevPridani.Name = "nazevPridani";
            this.nazevPridani.Size = new System.Drawing.Size(185, 23);
            this.nazevPridani.TabIndex = 0;
            // 
            // buttonPridani
            // 
            this.buttonPridani.Location = new System.Drawing.Point(27, 126);
            this.buttonPridani.Name = "buttonPridani";
            this.buttonPridani.Size = new System.Drawing.Size(264, 37);
            this.buttonPridani.TabIndex = 7;
            this.buttonPridani.Text = "Přidat";
            this.buttonPridani.UseVisualStyleBackColor = true;
            this.buttonPridani.Click += new System.EventHandler(this.buttonPridani_Click);
            // 
            // comboBoxJednotka
            // 
            this.comboBoxJednotka.FormattingEnabled = true;
            this.comboBoxJednotka.Location = new System.Drawing.Point(106, 49);
            this.comboBoxJednotka.Name = "comboBoxJednotka";
            this.comboBoxJednotka.Size = new System.Drawing.Size(128, 24);
            this.comboBoxJednotka.TabIndex = 8;
            // 
            // PridaniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(316, 175);
            this.Controls.Add(this.comboBoxJednotka);
            this.Controls.Add(this.buttonPridani);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pocetPridani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nazevPridani);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "PridaniForm";
            this.Text = "Přidát potraviny";
            this.Load += new System.EventHandler(this.PridaniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxJednotka;


        private System.Windows.Forms.Button buttonPridani;

        private System.Windows.Forms.TextBox nazevPridani;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pocetPridani;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}