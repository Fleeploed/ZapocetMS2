using System.ComponentModel;

namespace ZapocetMS2.Jidlo
{
    partial class VypisJidloForm
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
            this.textBoxHledani = new System.Windows.Forms.TextBox();
            this.dataGridNazev = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridSuroviny = new System.Windows.Forms.DataGridView();
            this.buttonPridani = new System.Windows.Forms.Button();
            this.buttonOdebrani = new System.Windows.Forms.Button();
            this.textBoxRecept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridNazev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridSuroviny)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadejte název jídla:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxHledani
            // 
            this.textBoxHledani.Location = new System.Drawing.Point(162, 17);
            this.textBoxHledani.Name = "textBoxHledani";
            this.textBoxHledani.Size = new System.Drawing.Size(317, 22);
            this.textBoxHledani.TabIndex = 1;
            this.textBoxHledani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHledani_KeyPress);
            // 
            // dataGridNazev
            // 
            this.dataGridNazev.AllowUserToAddRows = false;
            this.dataGridNazev.AllowUserToDeleteRows = false;
            this.dataGridNazev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNazev.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridNazev.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridNazev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNazev.Location = new System.Drawing.Point(12, 48);
            this.dataGridNazev.Name = "dataGridNazev";
            this.dataGridNazev.RowHeadersVisible = false;
            this.dataGridNazev.RowTemplate.Height = 24;
            this.dataGridNazev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNazev.Size = new System.Drawing.Size(467, 184);
            this.dataGridNazev.TabIndex = 2;
            this.dataGridNazev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNazev_CellContentClick);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(12, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(749, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Suroviny";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridSuroviny
            // 
            this.dataGridSuroviny.AllowUserToAddRows = false;
            this.dataGridSuroviny.AllowUserToDeleteRows = false;
            this.dataGridSuroviny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuroviny.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridSuroviny.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridSuroviny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSuroviny.Location = new System.Drawing.Point(11, 266);
            this.dataGridSuroviny.Name = "dataGridSuroviny";
            this.dataGridSuroviny.RowHeadersVisible = false;
            this.dataGridSuroviny.RowTemplate.Height = 24;
            this.dataGridSuroviny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuroviny.Size = new System.Drawing.Size(750, 175);
            this.dataGridSuroviny.TabIndex = 6;
            // 
            // buttonPridani
            // 
            this.buttonPridani.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPridani.Location = new System.Drawing.Point(543, 6);
            this.buttonPridani.Name = "buttonPridani";
            this.buttonPridani.Size = new System.Drawing.Size(105, 36);
            this.buttonPridani.TabIndex = 7;
            this.buttonPridani.Text = "Přidat jídlo";
            this.buttonPridani.UseVisualStyleBackColor = false;
            this.buttonPridani.Click += new System.EventHandler(this.buttonPridani_Click);
            // 
            // buttonOdebrani
            // 
            this.buttonOdebrani.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOdebrani.Location = new System.Drawing.Point(654, 6);
            this.buttonOdebrani.Name = "buttonOdebrani";
            this.buttonOdebrani.Size = new System.Drawing.Size(107, 36);
            this.buttonOdebrani.TabIndex = 8;
            this.buttonOdebrani.Text = "Odebrat jídlo";
            this.buttonOdebrani.UseVisualStyleBackColor = false;
            this.buttonOdebrani.Click += new System.EventHandler(this.buttonOdebrani_Click);
            // 
            // textBoxRecept
            // 
            this.textBoxRecept.Location = new System.Drawing.Point(485, 48);
            this.textBoxRecept.Multiline = true;
            this.textBoxRecept.Name = "textBoxRecept";
            this.textBoxRecept.Size = new System.Drawing.Size(276, 184);
            this.textBoxRecept.TabIndex = 9;
            // 
            // VypisJidloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(775, 459);
            this.Controls.Add(this.textBoxRecept);
            this.Controls.Add(this.buttonOdebrani);
            this.Controls.Add(this.buttonPridani);
            this.Controls.Add(this.dataGridSuroviny);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridNazev);
            this.Controls.Add(this.textBoxHledani);
            this.Controls.Add(this.label1);
            this.Name = "VypisJidloForm";
            this.Text = "Výpis jídlo";
            this.Load += new System.EventHandler(this.VypisJidloForm_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridNazev)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridSuroviny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxRecept;

        private System.Windows.Forms.Button buttonOdebrani;

        private System.Windows.Forms.Button buttonPridani;

        private System.Windows.Forms.DataGridView dataGridSuroviny;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.DataGridView dataGridNazev;

        private System.Windows.Forms.TextBox textBoxHledani;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}