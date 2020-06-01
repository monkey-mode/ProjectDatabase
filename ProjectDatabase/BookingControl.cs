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
    public partial class BookingControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=projectdatabase");
        MySqlCommand comm;
        int rid;
        string DDate;
        string RDate;
        bool rcheck;
        string stype;
        public BookingControl(string from,string to,string cost,int rid,string DDate,string RDate,bool rcheck,string stype)
        {
            
            InitializeComponent();
            fromTo2.Text = to + " - " + from;
            fromToLabel.Text = from + " - " +to;

            fromSmall2.Text = to;
            fromSmall.Text = from;

            toSmall2.Text = from;
            toSmall.Text = to;
            price.Text = cost + " / ฿";
            price2.Text = cost + " / ฿";

            this.rid = rid;
            this.DDate = DDate;
            this.RDate = RDate;
            this.rcheck = rcheck;
            if (!rcheck)
            {
                BookPanel2.Visible = false;
            }
            BookPanel1.BringToFront();
            this.stype = stype;
        }

        private void ChBtn_Click(object sender, EventArgs e)
        {
            if (!rcheck)
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
            else
            {
                BookPanel2.BringToFront();
                rcheck = !rcheck;
            }
        }
        private void open_connection()
        {
            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void loadBookingGridData()
        {
            string sql = "SELECT airplane.acompany, airplane.take_of_time, airplane.landing_time, airplane.totalTime, schedule.sdate, route.take_of_place, route.landing_place " +
                         "from booking inner join airplane inner join schedule inner join seat inner join route inner join seattype " +
                         "on booking.airplane_id = airplane.airplane_id and booking.seat_id = seat.seat_id and " +
                         "seat.seattype_id = seattype.seattype_id and seattype.seattype_name ='" + stype + "' and seat.status = 'free' and " +
                         "booking.sid = schedule.sid and schedule.rid = route.rid and route.rid = " + rid + " and schedule.sdate = '" + DDate + "'; ";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "booking");
            BookingGrid.DataSource = ds.Tables["booking"].DefaultView;
            BookingGrid.Columns[0].HeaderText = "Company";
            BookingGrid.Columns[1].HeaderText = "Depart\nTime";
            BookingGrid.Columns[2].HeaderText = "Arrive In\nTime";
            BookingGrid.Columns[3].HeaderText = "Total\nTime";
            BookingGrid.Columns[4].HeaderText = "Date";
            BookingGrid.Columns[5].HeaderText = "Depart\nPlace";
            BookingGrid.Columns[6].HeaderText = "Arrive In\nPlace";


            BookingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BookingGrid.AutoResizeColumns();

        }

        private void loadBookingGridData2()
        {
            string sql = "SELECT airplane.acompany, airplane.take_of_time, airplane.landing_time, airplane.totalTime, schedule.sdate, route.take_of_place, route.landing_place " +
                         "from booking inner join airplane inner join schedule inner join seat inner join route inner join seattype " +
                         "on booking.airplane_id = airplane.airplane_id and booking.seat_id = seat.seat_id and "+
                         "seat.seattype_id = seattype.seattype_id and seattype.seattype_name ='"+ stype+ "' and seat.status = '"+stype+"' and " +
                         "booking.sid = schedule.sid and schedule.rid = route.rid and route.rid != " + rid + " and schedule.sdate = '" + RDate + "'; ";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "booking");
            dataGridView1.DataSource = ds.Tables["booking"].DefaultView;
            dataGridView1.Columns[0].HeaderText = "Company";
            dataGridView1.Columns[1].HeaderText = "Depart\nTime";
            dataGridView1.Columns[2].HeaderText = "Arrive In\nTime";
            dataGridView1.Columns[3].HeaderText = "Total\nTime";
            dataGridView1.Columns[4].HeaderText = "Date";
            dataGridView1.Columns[5].HeaderText = "Depart\nPlace";
            dataGridView1.Columns[6].HeaderText = "Arrive In\nPlace";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoResizeColumns();

        }
        private void BookingControl_Load(object sender, EventArgs e)
        {
            open_connection();
            loadBookingGridData2();
            loadBookingGridData();
        }

        private void BookingCellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (BookingGrid.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string acompany = "";
                string depart = "";
                string arrive_in = "";
                string total = "";
                try
                {
                    acompany = BookingGrid.SelectedRows[0].Cells[0].Value.ToString();
                    depart = BookingGrid.SelectedRows[0].Cells[1].Value.ToString();
                    arrive_in = BookingGrid.SelectedRows[0].Cells[2].Value.ToString();
                    total = BookingGrid.SelectedRows[0].Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

                Acompany.Text = acompany;
                DepartTime.Text = depart;
                ArriveTime.Text = arrive_in;
                TotalTime.Text = total;
            }
        }

        private void CellClick2(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string acompany = "";
                string depart = "";
                string arrive_in = "";
                string total = "";
                try
                {
                    acompany = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    depart = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    arrive_in = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    total = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Company2.Text = acompany;
                depart2.Text = depart;
                arrive2.Text = arrive_in;
                total2.Text = total;
            }
        }
    }
}
