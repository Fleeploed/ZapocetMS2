using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZapocetMS2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pridatJidlo_Click(object sender, EventArgs e)
        {
            Form pridatjidloForm = new PridatJidloForm();
            pridatjidloForm.Show();
        }

        private void pridatKategorie_Click(object sender, EventArgs e)
        {
            Form pridatKategorieForm = new PridatKategorieForm();
            pridatKategorieForm.Show();
        }

        
        private void odebratKategorie_Click(object sender, EventArgs e)
        {
            Form odebratKategorieForm = new OdebratKategorieForm();
            odebratKategorieForm.Show();
        }
        
        private void Menu_Load(object sender, EventArgs e)
        {
            dataGridKategorie.DataSource = PopulateKategorie();
            dataGridKategorie.Columns[0].Visible = false;
        }

        private DataTable PopulateKategorie()
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string query = "SELECT id_kategorie, nazev_kategorie 'Nazev' from zapocetmswin2.kategorie";
            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, kategorie.DisplayRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, label2.DisplayRectangle, Color.Gray, ButtonBorderStyle.Solid);
        }

        private void dataGridKategorie_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            if (e.RowIndex >= 0)
            {
                try
                {
                    using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                    {
                        DataGridViewRow row = dataGridKategorie.Rows[e.RowIndex];
                        string query =
                            $"SELECT recept ,nazev_jidlo 'Nazev jidla', vaha 'Vaha (g)', cena from zapocetmswin2.jidlo where id_kategorie = '{row.Cells[0].Value.ToString()}'";

                        using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                datagridJidlo.DataSource = dt;
                                datagridJidlo.Columns[0].Visible = false;
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void jidloDatagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = datagridJidlo.Rows[e.RowIndex];
            receptTextBox.Text = row.Cells[0].Value.ToString();
        }

        private void kategorie_Click(object sender, EventArgs e)
        {
            dataGridKategorie.DataSource = PopulateKategorie();
            dataGridKategorie.Columns[0].Visible = false;
        }
    }
}