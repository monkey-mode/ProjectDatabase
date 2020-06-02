using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class Main : Form
    {
        static Main obj;
        string pass;
        public static Main Instance
        {
            get
            {
                if(obj == null)
                {
                    obj = new Main();
                }
                return obj;
            }
        }
        public string password
        {
            get { return pass; }
            set { pass = value; }
        }
        public Label User
        {
            get { return username; }
            set { username = value; }
        }
        public Panel Pnl
        {
            get { return mainPanel; }
            set { mainPanel = value; }
        }
        public Button BackBtn
        {
            get { return Back; }
            set { Back = value; }
        }

        public Button ticBtn
        {
            get { return ticket; }
            set { ticket = value; }
        }
        public Button LoginButton
        {
            get { return login; }
            set { login = value; }
        }
        public Button LogoutButton
        {
            get { return logout; }
            set { logout = value; }
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            logout.Visible = false;
            ticket.Visible = false;
            Back.Visible = false;
            obj = this;
            ScheduleControl sch = new ScheduleControl();
            sch.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(sch);

            mainPanel.Controls["ScheduleControl"].BringToFront();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Count == 2) 
            {
                mainPanel.Controls["ScheduleControl"].BringToFront();
                mainPanel.Controls.RemoveAt(1);
                Back.Visible = false;
            }
                
            else if (mainPanel.Controls.Count == 3)
            {
                mainPanel.Controls["BookingControl"].BringToFront();
                mainPanel.Controls.RemoveAt(1);
                Back.Visible = true;
            }
            else if (mainPanel.Controls.Count == 4)
            {
                mainPanel.Controls["CustomerControl"].BringToFront();
                mainPanel.Controls.RemoveAt(1);
                Back.Visible = true;
            }

        }

        private void ticket_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();

        }

        private void login_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login.Visible = true;
            logout.Visible = false;
            username.Text = "";
            ticBtn.Visible = false;

            Main.Instance.Pnl.Controls.RemoveByKey("BookingControl");
            Main.Instance.Pnl.Controls.RemoveByKey("CustomerControl");
            Main.Instance.Pnl.Controls.RemoveByKey("PaymentControl");
            Main.Instance.BackBtn.Visible = false;
        }
    }
}
