using System.ComponentModel;

namespace ZapocetMS2
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pridatJidlo = new System.Windows.Forms.ToolStripButton();
            this.pridatKategorie = new System.Windows.Forms.ToolStripButton();
            this.odebratKategorie = new System.Windows.Forms.ToolStripButton();
            this.kategorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridKategorie = new System.Windows.Forms.DataGridView();
            this.datagridJidlo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.receptTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridKategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.datagridJidlo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.pridatJidlo, this.pridatKategorie, this.odebratKategorie});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(680, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pridatJidlo
            // 
            this.pridatJidlo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.pridatJidlo.ForeColor = System.Drawing.Color.Black;
            this.pridatJidlo.Image = ((System.Drawing.Image) (resources.GetObject("pridatJidlo.Image")));
            this.pridatJidlo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pridatJidlo.Name = "pridatJidlo";
            this.pridatJidlo.Size = new System.Drawing.Size(112, 27);
            this.pridatJidlo.Text = "Přidat jídlo";
            this.pridatJidlo.Click += new System.EventHandler(this.pridatJidlo_Click);
            // 
            // pridatKategorie
            // 
            this.pridatKategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pridatKategorie.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.pridatKategorie.Image = ((System.Drawing.Image) (resources.GetObject("pridatKategorie.Image")));
            this.pridatKategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pridatKategorie.Name = "pridatKategorie";
            this.pridatKategorie.Size = new System.Drawing.Size(137, 27);
            this.pridatKategorie.Text = "Přidat Kategorie";
            this.pridatKategorie.Click += new System.EventHandler(this.pridatKategorie_Click);
            // 
            // odebratKategorie
            // 
            this.odebratKategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.odebratKategorie.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.odebratKategorie.Image = ((System.Drawing.Image) (resources.GetObject("odebratKategorie.Image")));
            this.odebratKategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.odebratKategorie.Name = "odebratKategorie";
            this.odebratKategorie.Size = new System.Drawing.Size(155, 27);
            this.odebratKategorie.Text = "Odebrat Kategorie";
            this.odebratKategorie.Click += new System.EventHandler(this.odebratKategorie_Click);
            // 
            // kategorie
            // 
            this.kategorie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kategorie.ForeColor = System.Drawing.SystemColors.Desktop;
            this.kategorie.Location = new System.Drawing.Point(0, 27);
            this.kategorie.Name = "kategorie";
            this.kategorie.Size = new System.Drawing.Size(286, 40);
            this.kategorie.TabIndex = 2;
            this.kategorie.Text = "Kategorie jídla";
            this.kategorie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.kategorie.Click += new System.EventHandler(this.kategorie_Click);
            this.kategorie.Paint += new System.Windows.Forms.PaintEventHandler(this.label1_Paint);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(285, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(395, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jídlo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Paint += new System.Windows.Forms.PaintEventHandler(this.label2_Paint);
            // 
            // dataGridKategorie
            // 
            this.dataGridKategorie.AllowUserToAddRows = false;
            this.dataGridKategorie.AllowUserToDeleteRows = false;
            this.dataGridKategorie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKategorie.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridKategorie.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridKategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKategorie.Location = new System.Drawing.Point(0, 66);
            this.dataGridKategorie.Name = "dataGridKategorie";
            this.dataGridKategorie.RowHeadersVisible = false;
            this.dataGridKategorie.RowTemplate.Height = 24;
            this.dataGridKategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKategorie.Size = new System.Drawing.Size(286, 129);
            this.dataGridKategorie.TabIndex = 4;
            this.dataGridKategorie.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridKategorie_CellMouseClick);
            // 
            // datagridJidlo
            // 
            this.datagridJidlo.AllowUserToAddRows = false;
            this.datagridJidlo.AllowUserToDeleteRows = false;
            this.datagridJidlo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridJidlo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridJidlo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.datagridJidlo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridJidlo.Location = new System.Drawing.Point(285, 66);
            this.datagridJidlo.Name = "datagridJidlo";
            this.datagridJidlo.RowHeadersVisible = false;
            this.datagridJidlo.RowTemplate.Height = 24;
            this.datagridJidlo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridJidlo.Size = new System.Drawing.Size(395, 327);
            this.datagridJidlo.TabIndex = 5;
            this.datagridJidlo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.jidloDatagrid_CellMouseClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recept";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receptTextBox
            // 
            this.receptTextBox.Location = new System.Drawing.Point(0, 224);
            this.receptTextBox.Multiline = true;
            this.receptTextBox.Name = "receptTextBox";
            this.receptTextBox.Size = new System.Drawing.Size(285, 168);
            this.receptTextBox.TabIndex = 7;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 393);
            this.Controls.Add(this.receptTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagridJidlo);
            this.Controls.Add(this.dataGridKategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategorie);
            this.Controls.Add(this.toolStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridKategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.datagridJidlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripButton odebratKategorie;

        private System.Windows.Forms.ToolStripButton pridatKategorie;

        private System.Windows.Forms.TextBox receptTextBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView datagridJidlo;

        private System.Windows.Forms.DataGridView dataGridKategorie;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label kategorie;

        private System.Windows.Forms.ToolStripButton pridatJidlo;

        private System.Windows.Forms.ToolStrip toolStrip1;

        #endregion
    }
}