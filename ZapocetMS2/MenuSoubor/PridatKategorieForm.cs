using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZapocetMS2
{
    public partial class PridatKategorieForm : Form
    {
        public PridatKategorieForm()
        {
            InitializeComponent();
        }

        private void buttonPridat_Click(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string query =
                "insert into zapocetmswin2.kategorie (nazev_kategorie) values (@nazev)";
            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                    {
                        mySqlConn.Open();
                        cmd.Parameters.AddWithValue("@nazev", textBoxNazev.Text);
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
    }
}