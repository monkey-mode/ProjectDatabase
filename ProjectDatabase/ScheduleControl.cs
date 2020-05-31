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
        public int selectSeatId()
        {
            string sql = "select seat_id from seat inner join seattype on seat.seattype_id = seattype.seattype_id and seattype.seattype_name = \"" +seatCombo.Text + "\" and seat.status = 'free' LIMIT 1;";
            comm = new MySqlCommand(sql, con);

            return (int)comm.ExecuteScalar();
        }
        private void SearchFlights_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectSeatId().ToString());
            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO projectdatabase.booking (bid, bdate, seat_id, airplane_id, sid) VALUES (@bid, @bdate, @seat_id,@airplane_id,@sid);";
            comm.Parameters.AddWithValue("@bid",null);
            comm.Parameters.AddWithValue("@bdate", DateTime.Now.ToString("yyyy-MM-dd  HH-mm-ss"));
            int num = selectSeatId();
            comm.Parameters.AddWithValue("@seat_id",num);
            comm.Parameters.AddWithValue("@airplane_id", 1);
            comm.Parameters.AddWithValue("@sid", 1);
            comm.ExecuteNonQuery();
            if (!Main.Instance.Pnl.Controls.ContainsKey("BookingControl"))
            {
                BookingControl bk = new BookingControl(fromBox.Text,toBox.Text,fromBox.SelectedIndex.ToString() + toBox.SelectedIndex.ToString());
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
