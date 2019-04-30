using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flightSchedular
{
    public partial class FlightSchedular : Form
    {
        //connect to db
        SqlConnection db_connection = new SqlConnection("Data Source=VITALIS;Initial Catalog=FlightSchedule;Integrated Security=True");
        SqlCommand sql_command = new SqlCommand();

        public FlightSchedular()
        {
            InitializeComponent();
        }

       private void dashboard_onload(object sender, EventArgs e)
        {
            addFlights_tab.Visible = false;
            generate_Schedule1.Visible = false;
            view_all_flights1.Visible = false;
            weather1.Visible = false;

        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            addFlights_tab.Visible = false;
            generate_Schedule1.Visible = false;
            view_all_flights1.Visible = false;
            weather1.Visible = false;
            welcome_textbox.Visible = true;
        }



        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_flight_button_Click(object sender, EventArgs e)
        {
            addFlights_tab.Visible = true;
            welcome_textbox.Visible = false;
            generate_Schedule1.Visible = false;
            weather1.Visible = false;
            view_all_flights1.Visible = false;
        }

        private void addFlights1_Load(object sender, EventArgs e)
        {

        }

        //this exit the application
        private void log_out_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void generate_Schedule1_Load(object sender, EventArgs e)
        {

        }

        private void schedule_flight_button_Click(object sender, EventArgs e)
        {          
            addFlights_tab.Visible = false;
            welcome_textbox.Visible = false;
            view_all_flights1.Visible = false;
            weather1.Visible = false;
            generate_Schedule1.Visible = true;
        }

        private void view_all_flights1_Load(object sender, EventArgs e)
        {

        }

        private void view_all_flights_btn_Click(object sender, EventArgs e)
        {
            //hide other components
            addFlights_tab.Visible = false;
            welcome_textbox.Visible = false;
            generate_Schedule1.Visible = false;
            weather1.Visible = false;
            view_all_flights1.Visible = true;



        }

        private void weather1_Load(object sender, EventArgs e)
        {

        }

        private void weather_button_Click(object sender, EventArgs e)
        {
            addFlights_tab.Visible = false;
            welcome_textbox.Visible = false;
            generate_Schedule1.Visible = false;
            view_all_flights1.Visible = false;
            weather1.Visible = true;
        }
    }
}
