using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZapocetMS2
{
    public partial class Potraviny : Form
    {
        public Potraviny()
        {
            InitializeComponent();
        }

        public  void Potraviny_Load(object sender, EventArgs e)
        {
            dataGridPotraviny.DataSource = this.populateDataTable();
        }

        private void hledani_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridPotraviny.DataSource = this.populateDataTable();
        }

        private DataTable populateDataTable()
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string query = "SELECT nazev_potraviny 'Nazev potraviny', pocet_potravin, jednotka from zapocetmswin2.potraviny";
            query += $" WHERE nazev_potraviny LIKE  '{hledani.Text}%'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form pridani = new PridaniForm();
            pridani.Show();
        }

        private string nazev_potraviny;

        private void dataGridPotraviny_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridPotraviny.Rows[e.RowIndex];
            nazev_potraviny = row.Cells[0].Value.ToString();
            Console.WriteLine(nazev_potraviny);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;
            string query = $"delete from zapocetmswin2.potraviny where nazev_potraviny='{nazev_potraviny}'";
            
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
                            dataGridPotraviny.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            dataGridPotraviny.DataSource = this.populateDataTable();
        }
    }
}