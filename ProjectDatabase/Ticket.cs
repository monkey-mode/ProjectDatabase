using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDatabase
{
    public partial class Ticket : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=projectdatabase");
        MySqlCommand comm;
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {

        }
        private void loadTicketGridData2()
        {
            /*string sql = "SELECT booking.bid,airplane.acompany, airplane.take_of_time, airplane.landing_time, airplane.totalTime, schedule.sdate, route.take_of_place, route.landing_place " +
                         "from booking inner join airplane inner join schedule inner join seat inner join route inner join seattype " +
                         "on booking.airplane_id = airplane.airplane_id and booking.seat_id = seat.seat_id and " +
                         "seat.seattype_id = seattype.seattype_id and seattype.seattype_name ='" + stype + "' and seat.status = 'free' and " +
                         "booking.sid = schedule.sid and schedule.rid = route.rid and route.rid != " + rid + " and schedule.sdate = '" + RDate + "'; ";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "booking");
            dataGridView1.DataSource = ds.Tables["booking"].DefaultView;
            dataGridView1.Columns[0].HeaderText = "Booking ID";
            dataGridView1.Columns[1].HeaderText = "Company";
            dataGridView1.Columns[2].HeaderText = "Depart\nTime";
            dataGridView1.Columns[3].HeaderText = "Arrive In\nTime";
            dataGridView1.Columns[4].HeaderText = "Total\nTime";
            dataGridView1.Columns[5].HeaderText = "Date";
            dataGridView1.Columns[6].HeaderText = "Depart\nPlace";
            dataGridView1.Columns[7].HeaderText = "Arrive In\nPlace";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();*/

        }
    }
}
