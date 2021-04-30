using System.ComponentModel;

namespace ZapocetMS2
{
    partial class PridatJidloForm
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
            this.textBoxNazevJidla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.textBoxVaha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSuroviny = new System.Windows.Forms.ComboBox();
            this.textBoxPocet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pridatSurovinu = new System.Windows.Forms.Button();
            this.dataGridViewSuroviny = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxRecept = new System.Windows.Forms.TextBox();
            this.pridatDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewSuroviny)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle) ((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Přidávání nového jídla do databáze";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNazevJidla
            // 
            this.textBoxNazevJidla.Location = new System.Drawing.Point(29, 92);
            this.textBoxNazevJidla.Name = "textBoxNazevJidla";
            this.textBoxNazevJidla.Size = new System.Drawing.Size(261, 22);
            this.textBoxNazevJidla.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kategorie";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Location = new System.Drawing.Point(29, 153);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(261, 24);
            this.comboBoxKategorie.TabIndex = 4;
            // 
            // textBoxVaha
            // 
            this.textBoxVaha.Location = new System.Drawing.Point(29, 216);
            this.textBoxVaha.Name = "textBoxVaha";
            this.textBoxVaha.Size = new System.Drawing.Size(117, 22);
            this.textBoxVaha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(29, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "Váha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCena
            // 
            this.textBoxCena.Location = new System.Drawing.Point(173, 216);
            this.textBoxCena.Name = "textBoxCena";
            this.textBoxCena.Size = new System.Drawing.Size(117, 22);
            this.textBoxCena.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(173, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cena";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(19, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(280, 207);
            this.label6.TabIndex = 1;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(19, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 196);
            this.label2.TabIndex = 10;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSuroviny
            // 
            this.comboBoxSuroviny.FormattingEnabled = true;
            this.comboBoxSuroviny.Location = new System.Drawing.Point(29, 309);
            this.comboBoxSuroviny.Name = "comboBoxSuroviny";
            this.comboBoxSuroviny.Size = new System.Drawing.Size(261, 24);
            this.comboBoxSuroviny.TabIndex = 12;
            // 
            // textBoxPocet
            // 
            this.textBoxPocet.Location = new System.Drawing.Point(108, 364);
            this.textBoxPocet.Name = "textBoxPocet";
            this.textBoxPocet.Size = new System.Drawing.Size(182, 22);
            this.textBoxPocet.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.Location = new System.Drawing.Point(29, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 33);
            this.label9.TabIndex = 13;
            this.label9.Text = "Počet:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(29, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "Název jídla";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(29, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 33);
            this.label8.TabIndex = 17;
            this.label8.Text = "Suroviny";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pridatSurovinu
            // 
            this.pridatSurovinu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pridatSurovinu.Location = new System.Drawing.Point(29, 410);
            this.pridatSurovinu.Name = "pridatSurovinu";
            this.pridatSurovinu.Size = new System.Drawing.Size(261, 37);
            this.pridatSurovinu.TabIndex = 19;
            this.pridatSurovinu.Text = "Přidat surovinu";
            this.pridatSurovinu.UseVisualStyleBackColor = false;
            this.pridatSurovinu.Click += new System.EventHandler(this.pridatSurovinu_Click);
            // 
            // dataGridViewSuroviny
            // 
            this.dataGridViewSuroviny.AllowUserToAddRows = false;
            this.dataGridViewSuroviny.AllowUserToDeleteRows = false;
            this.dataGridViewSuroviny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSuroviny.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSuroviny.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridViewSuroviny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSuroviny.Location = new System.Drawing.Point(305, 48);
            this.dataGridViewSuroviny.Name = "dataGridViewSuroviny";
            this.dataGridViewSuroviny.RowHeadersVisible = false;
            this.dataGridViewSuroviny.RowTemplate.Height = 24;
            this.dataGridViewSuroviny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSuroviny.Size = new System.Drawing.Size(324, 207);
            this.dataGridViewSuroviny.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label11.Location = new System.Drawing.Point(305, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(324, 196);
            this.label11.TabIndex = 21;
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Info;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label12.Location = new System.Drawing.Point(319, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(297, 33);
            this.label12.TabIndex = 22;
            this.label12.Text = "Recept";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRecept
            // 
            this.textBoxRecept.Location = new System.Drawing.Point(319, 309);
            this.textBoxRecept.Multiline = true;
            this.textBoxRecept.Name = "textBoxRecept";
            this.textBoxRecept.Size = new System.Drawing.Size(297, 138);
            this.textBoxRecept.TabIndex = 23;
            // 
            // pridatDB
            // 
            this.pridatDB.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pridatDB.Location = new System.Drawing.Point(19, 467);
            this.pridatDB.Name = "pridatDB";
            this.pridatDB.Size = new System.Drawing.Size(610, 44);
            this.pridatDB.TabIndex = 24;
            this.pridatDB.Text = "Přidat do DB";
            this.pridatDB.UseVisualStyleBackColor = false;
            this.pridatDB.Click += new System.EventHandler(this.pridatDB_Click);
            // 
            // PridatJidloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 526);
            this.Controls.Add(this.pridatDB);
            this.Controls.Add(this.textBoxRecept);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewSuroviny);
            this.Controls.Add(this.pridatSurovinu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxPocet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxSuroviny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVaha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxKategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNazevJidla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "PridatJidloForm";
            this.Text = "Přidat jídlo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PridatJidloForm_FormClosed);
            this.Load += new System.EventHandler(this.PridatJidloForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewSuroviny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button pridatDB;

        private System.Windows.Forms.TextBox textBoxRecept;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.DataGridView dataGridViewSuroviny;

        private System.Windows.Forms.Button pridatSurovinu;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPocet;

        private System.Windows.Forms.ComboBox comboBoxSuroviny;


        private System.Windows.Forms.Label label2;


        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVaha;
        private System.Windows.Forms.TextBox textBoxCena;

        private System.Windows.Forms.ComboBox comboBoxKategorie;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxNazevJidla;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}