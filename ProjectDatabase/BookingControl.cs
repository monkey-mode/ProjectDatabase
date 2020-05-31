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
        public BookingControl(string from,string to,string cost,int rid,string DDate)
        {
            
            InitializeComponent();
            fromToLabel.Text = from + " - " +to;
            fromSmall.Text = from;
            toSmall.Text = to;
            price.Text = cost + " / ฿";
            this.rid = rid;
            this.DDate = DDate;

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
        private void open_connection()
        {
            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void loadBookingGridData()
        {
            string sql = "select  airplane.acompany, airplane.take_of_time, airplane.landing_time, airplane.totalTime, schedule.sdate, route.take_of_place, route.landing_place " +
                         "from airplane inner join schedule inner join route "+
                         "on schedule.sid = airplane.sid and schedule.rid = route.rid and sdate = '"+DDate + "' and route.rid ="+ rid +"; ";
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
        private void BookingControl_Load(object sender, EventArgs e)
        {
            open_connection();
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
    }
}
