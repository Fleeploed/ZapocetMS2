using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZapocetMS2.Jidlo
{
    public partial class VypisJidloForm : Form
    {
        public VypisJidloForm()
        {
            InitializeComponent();
        }

        private void VypisJidloForm_Load(object sender, EventArgs e)
        {
            dataGridNazev.DataSource = this.PopulateJidlo();
            dataGridNazev.Columns[0].Visible = false;
        }
        private void textBoxHledani_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridNazev.DataSource = this.PopulateJidlo();
            dataGridNazev.Columns[0].Visible = false;
        }
        private DataTable PopulateJidlo()
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string query =
                "select id_jidlo, nazev_jidlo 'Nazev jidlo', vaha, cena, nazev_kategorie 'kategorie' from zapocetmswin2.jidlo natural join zapocetmswin2.kategorie";
            query += $" WHERE nazev_jidlo LIKE  '{textBoxHledani.Text}%'";
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

        private int id_jidlo = 0;
        private void dataGridNazev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;
            DataGridViewRow row = dataGridNazev.Rows[e.RowIndex];
            id_jidlo = Convert.ToInt32(row.Cells[0].Value.ToString());
            if (e.RowIndex >= 0)
            {
                try
                {
                    using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                    {
                        mySqlConn.Open();
                        
                        string query =
                            $"select nazev_potraviny 'Nazev potraviny', pocet_suroviny, jednotka from zapocetmswin2.potraviny natural join zapocetmswin2.suroviny where id_jidlo= '{row.Cells[0].Value.ToString()}'";
                        using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                        {
                            using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);
                                dataGridSuroviny.DataSource = dt;
                            }
                        }

                        string queryRecept =
                            $"select recept from zapocetmswin2.jidlo where id_jidlo='{row.Cells[0].Value.ToString()}'";
                        using (MySqlCommand cmd = new MySqlCommand(queryRecept, mySqlConn))
                        {
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                    textBoxRecept.Text = reader.GetString("recept");
                            }
                        }

                        mySqlConn.Close();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void buttonPridani_Click(object sender, EventArgs e)
        {
            Form pridatJidloForm = new PridatJidloForm();
            pridatJidloForm.Show();
        }

        private void buttonOdebrani_Click(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;
            string query = $"delete from zapocetmswin2.jidlo where id_jidlo={id_jidlo}";

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
                            dataGridNazev.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            dataGridNazev.DataSource = this.PopulateJidlo();
            dataGridNazev.Columns[0].Visible = false;
        }
    }
}