using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZapocetMS2
{
    public partial class PridatJidloForm : Form
    {
        public PridatJidloForm()
        {
            InitializeComponent();
        }

        private void PridatJidloForm_Load(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string queryKategorie = "select nazev_kategorie from zapocetmswin2.kategorie";
            string querySuroviny = "select nazev_potraviny from zapocetmswin2.potraviny";
            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    mySqlConn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(queryKategorie, mySqlConn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString("nazev_kategorie");
                                comboBoxKategorie.Items.Add(name);
                                comboBoxKategorie.DropDownStyle = ComboBoxStyle.DropDownList;
                                comboBoxKategorie.SelectedIndex = comboBoxKategorie.Items.Count - 1;
                            }
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand(querySuroviny, mySqlConn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboBoxSuroviny.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                                comboBoxSuroviny.AutoCompleteSource = AutoCompleteSource.ListItems;
                                string name = reader.GetString("nazev_potraviny");
                                comboBoxSuroviny.Items.Add(name);
                            }
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

        private void pridatSurovinu_Click(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;
            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    string queryID =
                        $"select id_potraviny from zapocetmswin2.potraviny where nazev_potraviny = '{comboBoxSuroviny.Text}'";
                    string idPotraviny = "";

                    mySqlConn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(queryID, mySqlConn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                idPotraviny = reader.GetString("id_potraviny");
                        }
                    }

                    string queryAdd =
                        $"insert into zapocetmswin2.suroviny (id_potraviny, pocet_suroviny) values ({idPotraviny},{textBoxPocet.Text})";
                    using (MySqlCommand cmd = new MySqlCommand(queryAdd, mySqlConn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        reader.Close();
                    }

                    string queryIns =
                        "select nazev_potraviny 'Nazev potraviny', pocet_suroviny 'Pocet suroviny' from zapocetmswin2.potraviny natural join zapocetmswin2.suroviny where id_jidlo is null";

                    using (MySqlCommand cmd = new MySqlCommand(queryIns, mySqlConn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridViewSuroviny.DataSource = dt;
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

        private void pridatDB_Click(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string idKat = "";
            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    mySqlConn.Open();
                    string queryIDKat =
                        $"select id_kategorie from zapocetmswin2.kategorie where nazev_kategorie='{comboBoxKategorie.Text}'";

                    using (MySqlCommand cmd = new MySqlCommand(queryIDKat, mySqlConn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                idKat = reader.GetString("id_kategorie");
                        }
                    }

                    string queryINS =
                        "insert into zapocetmswin2.jidlo (nazev_jidlo, vaha, cena, recept, id_kategorie) values (@nazev_jidlo, @vaha, @cena, @recept, @id_kategorie)";

                    using (MySqlCommand cmd = new MySqlCommand(queryINS, mySqlConn))
                    {
                        cmd.Parameters.AddWithValue("@nazev_jidlo", textBoxNazevJidla.Text);
                        cmd.Parameters.AddWithValue("@vaha", textBoxVaha.Text);
                        cmd.Parameters.AddWithValue("@cena", textBoxCena.Text);
                        cmd.Parameters.AddWithValue("@recept", textBoxRecept.Text);
                        cmd.Parameters.AddWithValue("@id_kategorie", idKat);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        reader.Close();
                    }

                    string queryIDJidlo = "SELECT id_jidlo FROM zapocetmswin2.jidlo ORDER BY id_jidlo DESC LIMIT 1";
                    int idJidlo = 0;
                    using (MySqlCommand cmd = new MySqlCommand(queryIDJidlo, mySqlConn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                                idJidlo = Convert.ToInt32(reader.GetString("id_jidlo"));
                        }
                    }

                    string queryUPD =
                        $"update zapocetmswin2.suroviny set id_jidlo={idJidlo} WHERE suroviny.id_jidlo IS NULL";
                    using (MySqlCommand cmd = new MySqlCommand(queryUPD, mySqlConn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        reader.Close();
                    }

                    DialogResult dialog = MessageBox.Show("Pridano");
                    if (dialog == DialogResult.OK) this.Close();
                    mySqlConn.Close();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                MessageBox.Show(exception.Message);
            }
        }

        private void PridatJidloForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    mySqlConn.Open();
                    string query = "delete from zapocetmswin2.suroviny where id_jidlo IS NULL;";
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        reader.Close();
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
}