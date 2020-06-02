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
using System.Data.SqlTypes;

namespace ProjectDatabase
{
    public partial class ScheduleControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=projectdatabase");
        MySqlCommand comm;
        public ScheduleControl()
        {
            InitializeComponent();
        }
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void SearchFlights_Click(object sender, EventArgs e)
        {
            string sql = "select cost from seat inner join seattype on seat.seattype_id = seattype.seattype_id and seattype.seattype_name = \"" + seatCombo.Text + "\" and seat.status = 'free' LIMIT 1;";
            comm = new MySqlCommand(sql, con);
            var cost = comm.ExecuteScalar();
            var sel = fromBox.SelectedIndex.ToString() + toBox.SelectedIndex.ToString();
            var rid = 0;
            if (sel == "01")
            {
                rid = 1;
            }
            else
                rid = 2;
            string DDate = DepatureDate.Value.ToString("yyyy-MM-dd");
            string RDate = returnDate.Value.ToString("yyyy-MM-dd");

            if (!Main.Instance.Pnl.Controls.ContainsKey("BookingControl"))
            {
                BookingControl bk = new BookingControl(fromBox.Text,toBox.Text,cost.ToString(),rid,DDate,RDate,returnCheck.Checked,seatCombo.Text);
                bk.Dock = DockStyle.Fill;
                Main.Instance.Pnl.Controls.Add(bk);
            } 
            Main.Instance.Pnl.Controls["BookingControl"].BringToFront();
            Main.Instance.BackBtn.Visible = true;
        }
        private void checkReturn(object sender, EventArgs e)
        {
            if (returnCheck.Checked == false)
                returnDate.Visible = false;
            else
                returnDate.Visible = true;
        }

        private void ScheduleControl_Load(object sender, EventArgs e)
        {
            open_connection();
            fromBox.SelectedIndex = 0;
            toBox.SelectedIndex = 1;
            seatCombo.SelectedIndex = 0;
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
