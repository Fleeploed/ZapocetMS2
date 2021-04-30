using System.ComponentModel;

namespace ZapocetMS2
{
    partial class Potraviny
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
            this.dataGridPotraviny = new System.Windows.Forms.DataGridView();
            this.hledani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridPotraviny)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPotraviny
            // 
            this.dataGridPotraviny.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPotraviny.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPotraviny.Location = new System.Drawing.Point(12, 65);
            this.dataGridPotraviny.Name = "dataGridPotraviny";
            this.dataGridPotraviny.RowHeadersVisible = false;
            this.dataGridPotraviny.RowTemplate.Height = 24;
            this.dataGridPotraviny.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPotraviny.Size = new System.Drawing.Size(601, 446);
            this.dataGridPotraviny.TabIndex = 1;
            this.dataGridPotraviny.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPotraviny_CellContentClick);
            // 
            // hledani
            // 
            this.hledani.Location = new System.Drawing.Point(75, 28);
            this.hledani.Name = "hledani";
            this.hledani.Size = new System.Drawing.Size(287, 22);
            this.hledani.TabIndex = 2;
            this.hledani.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hledani_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hledat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Přidat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(511, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Odebrat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Potraviny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(625, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hledani);
            this.Controls.Add(this.dataGridPotraviny);
            this.Controls.Add(this.label1);
            this.Name = "Potraviny";
            this.Text = "Potraviny";
            this.Load += new System.EventHandler(this.Potraviny_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridPotraviny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox hledani;

        private System.Windows.Forms.DataGridView dataGridPotraviny;

        #endregion
    }
}