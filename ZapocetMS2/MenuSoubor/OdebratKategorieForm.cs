using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZapocetMS2
{
    public partial class OdebratKategorieForm : Form
    {
        public OdebratKategorieForm()
        {
            InitializeComponent();
        }

        private void buttonOdebrat_Click(object sender, EventArgs e)
        {
            //connection DataBase 
            IndexForm connIndex = new IndexForm();
            string conn = connIndex.Conn;

            string query =
                "delete from zapocetmswin2.kategorie where nazev_kategorie=@nazev";
            try
            {
                using (MySqlConnection mySqlConn = new MySqlConnection(conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConn))
                    {
                        mySqlConn.Open();
                        cmd.Parameters.AddWithValue("@nazev", textBoxNazev.Text);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        DialogResult dialog = MessageBox.Show("Odebrano");
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