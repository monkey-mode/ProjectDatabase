using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class Schedule : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=projectdatabase");
        MySqlCommand comm;
        public Schedule()
        {
            InitializeComponent();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }

        private void swapClick(object sender, EventArgs e)
        {

        }

        private void checkReturn(object sender, EventArgs e)
        {
            if (returnCheck.Checked == false)
                returnDate.Visible = false;
            else
                returnDate.Visible = true;
        }

        private void SearchFlights_Click(object sender, EventArgs e)
        {

        }
    }
}
