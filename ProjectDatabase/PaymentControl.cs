using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectDatabase
{
    public partial class PaymentControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=projectdatabase");
        MySqlCommand comm;
        string sqlinsertcus;
        bool rcheck;
        string[] departinfo;
        string[] returninfo;
        string cname;
        string cost;
        public PaymentControl(string sqlinsertcus, bool rcheck, string departinfo, string returninfo,string cname,string cost)
        {
            InitializeComponent();
            this.sqlinsertcus = sqlinsertcus;
            this.departinfo = departinfo.Split('|');
            if(rcheck)
                this.returninfo = returninfo.Split('|');
            this.cname = cname;
            this.rcheck = rcheck;
            labelname.Text = cname;
            this.cost = cost;
        }
        private void PaymentControl_Load(object sender, EventArgs e)
        {
            int sum = int.Parse(cost);
            nametic2.Visible = false;
            money1.Text = "THB  " + cost;
            if (rcheck)
            {
                nametic2.Visible = true;
                money2.Text = "THB  " + cost;
                sum += int.Parse(cost);
            }
            fee.Text = "THB  " + sum * 0.01;
            label17.Text = "THB  " + (sum + sum * 0.01);
            credit.BringToFront();
            crebtn.BackColor = Color.White;
            crebtn.ForeColor = Color.Black;
            bid1.Text = departinfo[0];
            acom1.Text = departinfo[1];
            date1.Text = departinfo[5];
            DepartTime1.Text = departinfo[2];
            ArriveTime1.Text = departinfo[3];
            TotalTime1.Text = departinfo[4];
            fromSmall1.Text = departinfo[6];
            toSmall1.Text = departinfo[7];
            if (!rcheck)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                bid2.Text = returninfo[0];
                acom2.Text = returninfo[1];
                date2.Text = returninfo[5];
                DepartTime2.Text = returninfo[2];
                ArriveTime2.Text = returninfo[3];
                TotalTime2.Text = returninfo[4];
                fromSmall2.Text = returninfo[6];
                toSmall2.Text = returninfo[7];

            }
            nameTic.Text = acom1.Text;
            if (rcheck)
            {
                nametic2.Text = acom2.Text;
            }
        }

        private void crebtn_Click(object sender, EventArgs e)
        {
            credit.BringToFront();
            crebtn.BackColor = Color.White;
            crebtn.ForeColor = Color.Black;

            elebtn.BackColor = Color.FromArgb(255, 128, 0);
            elebtn.ForeColor = Color.White;
        }

        private void elebtn_Click(object sender, EventArgs e)
        {
            eleven.BringToFront();
            elebtn.BackColor = Color.White;
            elebtn.ForeColor = Color.Black;

            crebtn.BackColor = Color.FromArgb(255, 128, 0);
            crebtn.ForeColor = Color.White;
        }
    }
}
