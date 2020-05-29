using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectDatabase
{
    public partial class Customer : Form
    {
        MySqlConnection con = new MySqlConnection("host=localost;user=root;password=;database=projectdatabase");
        MySqlCommand cmd;

        public Customer()
        {
            InitializeComponent();
        }

        private void From_Load(object sender, EventArgs e)
        {
   
        }
    }
}
