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
    public partial class ScheduleControl : UserControl
    {
        public ScheduleControl()
        {
            InitializeComponent();
        }

        private void SearchFlights_Click(object sender, EventArgs e)
        {
            mainControl.showControl(new BookingControl(), nextPage);
        }
        private void checkReturn(object sender, EventArgs e)
        {
            if (returnCheck.Checked == false)
                returnDate.Visible = false;
            else
                returnDate.Visible = true;
        }

        private void nextPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            fromBox.SelectedIndex = 0;
            toBox.SelectedIndex = 1;
        }

        private void swap_Click(object sender, EventArgs e)
        {
            int a;
            a = fromBox.SelectedIndex;
            fromBox.SelectedIndex = toBox.SelectedIndex;
            toBox.SelectedIndex = a;
        }

        private void selectFromChange(object sender, EventArgs e)
        {
            if (fromBox.SelectedIndex == 0)
                toBox.SelectedIndex = 1;
            else
                toBox.SelectedIndex = 0;
        }

        private void selectToChange(object sender, EventArgs e)
        {
            if (toBox.SelectedIndex == 0)
                fromBox.SelectedIndex = 1;
            else
                fromBox.SelectedIndex = 0;
        }
    }
}
