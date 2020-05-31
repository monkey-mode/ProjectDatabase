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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
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
    }
}
