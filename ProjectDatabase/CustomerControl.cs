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
        public CustomerControl()
        {
            InitializeComponent();
        }

        private void ConBtn_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.Pnl.Controls.ContainsKey("PaymentControl"))
            {
                PaymentControl pay = new PaymentControl();
                pay.Dock = DockStyle.Fill;
                Main.Instance.Pnl.Controls.Add(pay);
            }
            Main.Instance.Pnl.Controls["PaymentControl"].BringToFront();
            Main.Instance.BackBtn.Visible = true;
        }
    }
}
