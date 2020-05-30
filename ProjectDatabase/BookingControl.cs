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
        public BookingControl(string from,string to)
        {
            InitializeComponent();
            fromToLabel.Text = from + " - " +to;
            fromSmall.Text = from;
            toSmall.Text = to;
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
            MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void loadBookingGridData()
        {
            string sql = "SELECT * FROM projectdatabase.booking";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "booking");
            BookingGrid.DataSource = ds.Tables["booking"].DefaultView;
            
        }
        private void BookingControl_Load(object sender, EventArgs e)
        {
            open_connection();
            loadBookingGridData();
        }
    }
}
