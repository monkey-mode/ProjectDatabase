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
    public partial class Login : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=projectdatabase");
        MySqlCommand comm;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string email = mail.Text;
            string pass = password.Text;

            string sql = "SELECT * FROM projectdatabase.customer;";
            comm = new MySqlCommand(sql, con);
            MySqlDataReader reader = comm.ExecuteReader();
            bool find = false;
            while (reader.Read())
            {
                if(reader.GetString("cus_email") == email && reader.GetString("pass") == pass){

                    Main.Instance.LoginButton.Visible = false;
                    Main.Instance.User.Text = reader.GetString("cus_email");
                    Main.Instance.LogoutButton.Visible = true;
                    Main.Instance.password = pass;
                    this.Close();
                    find = true;
                    break;
                }
                
            }
            reader.Close();
            if (!find)
            {
                MessageBox.Show("Your email or password is incorrect. Please try again.");
            }
            
        }

        private void open_connection()
        {
            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            open_connection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register regis = new Register();
            regis.Show();
        }
    }
}
