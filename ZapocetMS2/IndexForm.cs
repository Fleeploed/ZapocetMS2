// Tento zdrojovy kod jsem vypracoval zcela samostatne bez cizi pomoci
// Alisher Ibrayev 35732

using System;
using System.Windows.Forms;
using ZapocetMS2.Jidlo;

namespace ZapocetMS2
{
    public partial class IndexForm : Form  
    {
        public string Conn
        {
            get => conn;
        }
        private string conn = "datasource=localhost;port=3306;username=alisher;password=alisher2013;";
        public IndexForm()  
        {  
            InitializeComponent();  
        }
        private void pocetPotraviny_Click(object sender, EventArgs e)
        {
            Form potaviny = new Potraviny();
            potaviny.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
        }

        private void buttonJidlo_Click(object sender, EventArgs e)
        {
            Form vypisJidloForm = new VypisJidloForm();
            vypisJidloForm.Show();
        }
    }  
} 