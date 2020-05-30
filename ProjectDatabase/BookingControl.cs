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
    public partial class BookingControl : UserControl
    {
        public BookingControl()
        {
            InitializeComponent();
        }

        private void ChBtn_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.Pnl.Controls.ContainsKey("CustomerControl"))
            {
                CustomerControl cus = new CustomerControl();
                cus.Dock = DockStyle.Fill;
                Main.Instance.Pnl.Controls.Add(cus);
            }
            Main.Instance.Pnl.Controls["CustomerControl"].BringToFront();
            Main.Instance.BackBtn.Visible = true;
        }

        private void BookingControl_Load(object sender, EventArgs e)
        {

        }
    }
}
