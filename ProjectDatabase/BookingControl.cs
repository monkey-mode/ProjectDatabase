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
            mainControl.showControl(new CustomerControl(), nextPage);
        }

        private void BookingControl_Load(object sender, EventArgs e)
        {

        }
    }
}
