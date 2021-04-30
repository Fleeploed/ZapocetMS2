using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZapocetMS2
{
    public partial class PridaniForm : Form
    {
        public PridaniForm()
        {
            InitializeComponent();
            
        }

        private void buttonPridani_Click(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string query =
                "insert into zapocetmswin2.potraviny (nazev_potraviny, pocet_potravin, jednotka) values (@nazev, @pocet, @jednotka)";
            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                    {
                        mySqlConn.Open();
                        cmd.Parameters.AddWithValue("@nazev", nazevPridani.Text);
                        cmd.Parameters.AddWithValue("@pocet", pocetPridani.Text);
                        cmd.Parameters.AddWithValue("@jednotka", comboBoxJednotka.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        DialogResult dialog = MessageBox.Show("Pridano");
                        if (dialog == DialogResult.OK) this.Close();
                        reader.Read();
                        reader.Close();
                        mySqlConn.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void PridaniForm_Load(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;
            string query = "select nazev_jednotka from zapocetmswin2.jednotka";
            MySqlConnection mysqlcon = new MySqlConnection(conn);
            mysqlcon.Open();
            MySqlCommand cmd = new MySqlCommand(query, mysqlcon);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString("nazev_jednotka");
                comboBoxJednotka.Items.Add(name);
                comboBoxJednotka.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxJednotka.SelectedIndex = comboBoxJednotka.Items.Count - 1;
            }
            mysqlcon.Close();
        }
    }
}