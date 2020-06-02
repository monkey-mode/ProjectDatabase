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
        string[] pass = new string[2];
        public PaymentControl(string sqlinsertcus, bool rcheck, string departinfo, string returninfo,string cname,string cost,string email,string mobilenum)
        {
            pass[0] = email;
            pass[1] = mobilenum;
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
            open_connection();
            int sum = int.Parse(cost);
            nametic2.Visible = false;
            nametic72.Visible = false;
            money1.Text = "THB  " + cost;
            money71.Text = "THB  " + cost;
            if (rcheck)
            {
                nametic2.Visible = true;
                nametic72.Visible = true;
                money2.Text = "THB  " + cost;
                money72.Text = "THB  " + cost;
                sum += int.Parse(cost);
            }
            fee.Text = "THB  " + sum * 0.01;
            fee2.Text = "THB  " + sum * 0.01;
            label17.Text = "THB  " + (sum + sum * 0.01);
            total7.Text = "THB  " + (sum + sum * 0.01);
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
            nametic71.Text = acom1.Text;
            if (rcheck)
            {
                nametic2.Text = acom2.Text;
                nametic72.Text = acom2.Text;
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
        private void open_connection()
        {
            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comm = con.CreateCommand();
            comm.CommandText = sqlinsertcus;
            comm.ExecuteNonQuery();

            comm = con.CreateCommand();
            comm.CommandText = "insert into check_in values(null,'7-Eleven','Please Scan Barcode And Pay','Pending',"+ departinfo[0] +")";
            comm.ExecuteNonQuery();
            if (rcheck)
            {
                comm = con.CreateCommand();
                comm.CommandText = "insert into check_in values(null,'7-Eleven','Please Scan Barcode And Pay','Pending'," + returninfo[0] + ")";
                comm.ExecuteNonQuery();
            }

            string sql = "select cid from customer where cus_email = '" + pass[0] + "' and phone_number = " + pass[1] + ";";
            comm = new MySqlCommand(sql, con);
            var cid = comm.ExecuteScalar();

            string sql2 = "select check_id from check_in where bid =" + departinfo[0] + ";";
            comm = new MySqlCommand(sql2, con);
            var bid = comm.ExecuteScalar();

            comm = con.CreateCommand();
            comm.CommandText = "insert into ticket values(null," + cid + "," + bid + ")";
            comm.ExecuteNonQuery();

            if (rcheck)
            {
                string sql3 = "select check_id from check_in where bid =" + returninfo[0] + ";";
                comm = new MySqlCommand(sql3, con);
                var bid2 = comm.ExecuteScalar();

                comm = con.CreateCommand();
                comm.CommandText = "insert into ticket values(null," + cid + "," + bid2 + ")";
                comm.ExecuteNonQuery();
            }
            Main.Instance.Pnl.Controls.RemoveByKey("BookingControl");
            Main.Instance.Pnl.Controls.RemoveByKey("CustomerControl");
            Main.Instance.Pnl.Controls.RemoveByKey("PaymentControl");
            Main.Instance.BackBtn.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string card = cardNum.Text + "|" + valid.Text + "|" + cvv.Text + "|" + nameOn.Text;
            comm = con.CreateCommand();
            comm.CommandText = sqlinsertcus;
            comm.ExecuteNonQuery();

            comm = con.CreateCommand();
            comm.CommandText = "insert into check_in values(null,'Credit Card','"+card+"','Pending'," + departinfo[0] + ")";
            comm.ExecuteNonQuery();

            if (rcheck)
            {
                comm = con.CreateCommand();
                comm.CommandText = "insert into check_in values(null,'Credit Card','" + card + "','Pending'," + returninfo[0] + ")";
                comm.ExecuteNonQuery();

            }
            string sql = "select cid from customer where cus_email = '"+pass[0]+"' and phone_number = "+pass[1]+";";
            comm = new MySqlCommand(sql, con);
            var cid = comm.ExecuteScalar();

            string sql2 = "select check_id from check_in where bid =" +departinfo[0] +";";
            comm = new MySqlCommand(sql2, con);
            var bid = comm.ExecuteScalar();

            comm = con.CreateCommand();
            comm.CommandText = "insert into ticket values(null," + cid + "," + bid + ")";
            comm.ExecuteNonQuery();

            if (rcheck)
            {
                string sql3 = "select check_id from check_in where bid =" + returninfo[0] + ";";
                comm = new MySqlCommand(sql3, con);
                var bid2 = comm.ExecuteScalar();

                comm = con.CreateCommand();
                comm.CommandText = "insert into ticket values(null," + cid + "," + bid2 + ")";
                comm.ExecuteNonQuery();
            }
            
            Main.Instance.Pnl.Controls.RemoveByKey("BookingControl");
            Main.Instance.Pnl.Controls.RemoveByKey("CustomerControl");
            Main.Instance.Pnl.Controls.RemoveByKey("PaymentControl");
            Main.Instance.BackBtn.Visible = false;
        }
    }
}
