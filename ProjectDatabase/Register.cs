using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class Register : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=projectdatabase");
        MySqlCommand comm;
        public Register()
        {
            InitializeComponent();
        }
        private void open_connection()
        {
            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }

        private void Register_Load(object sender, EventArgs e)
        {
            open_connection();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            string email = mail.Text;
            string pass = password.Text;

            string sql = "SELECT * FROM projectdatabase.customer;";
            comm = new MySqlCommand(sql, con);
            MySqlDataReader reader = comm.ExecuteReader();
            bool find = false;
            while (reader.Read())
            {
                if (reader.GetString("cus_email") == email)
                {
                    find = true;
                }
            }
            reader.Close();
            if (find)
            {
                MessageBox.Show("Username already exists");
            }
            else if (pass.Equals(comfirm.Text))
            {
                comm = con.CreateCommand();
                comm.CommandText = "insert into customer(cid, cus_email,pass) values(null,'" + email+ "','"+pass+"')";
                comm.ExecuteNonQuery();
                MessageBox.Show("Register Complete");
                this.Close();

            }
            else
            {
                MessageBox.Show("Password does not match");
            }

        }
    }
}
