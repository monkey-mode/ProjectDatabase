using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class CustomerControl : UserControl
    {
        bool rcheck;
        string bids1;
        string bids2;
        string cost;
        public CustomerControl(bool rcheck,string bids1,string bids2,string cost)
        {
            InitializeComponent();
            this.rcheck = rcheck;
            this.bids1 = bids1;
            this.bids2 = bids2;
            this.cost = cost;
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            string name = Fname.Text;
            string lastname = Lname.Text;
            string mobileNumber = numeric.Value.ToString();
            string Email = mail.Text;
            string DOB = dob.Value.ToString("yyyy-MM-dd");
            string sqlupdate = "update customer "+
                               "set cname = '"+ comboBox1.Text + name + " " + lastname + "', phone_number = "+ mobileNumber + ", dob = '"+DOB+"' " +
                               "where cus_email = '"+Email+"' and pass = "+Main.Instance.password+"; ";
            if (name != "" && lastname != "" && Email != "")
            {
                if (!Main.Instance.Pnl.Controls.ContainsKey("PaymentControl"))
                {
                    PaymentControl pay = new PaymentControl(sqlupdate, rcheck, bids1, bids2, comboBox1.Text + name + " " + lastname,cost,Email,mobileNumber);
                    pay.Dock = DockStyle.Fill;
                    Main.Instance.Pnl.Controls.Add(pay);
                }
                Main.Instance.Pnl.Controls["PaymentControl"].BringToFront();
                Main.Instance.BackBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Please Input Details");
            }
            
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void CustomerControl_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Bnum.SelectedIndex = 0;
            mail.Text = Main.Instance.User.Text;
            
        }
    }
}
