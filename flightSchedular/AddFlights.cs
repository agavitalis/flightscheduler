using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace flightSchedular
{
    public partial class AddFlights : UserControl
    {
        //connect to db
        SqlConnection db_connection = new SqlConnection("Data Source=VITALIS;Initial Catalog=FlightSchedule; MultipleActiveResultSets=true; Integrated Security=True");
        SqlCommand sql_command = new SqlCommand();
        public AddFlights()
        {
            InitializeComponent();
           
        }

        private void AddFlights_Load(object sender, EventArgs e)
        {
             sql_command.Connection = db_connection;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_flight_Click(object sender, EventArgs e)
        {
            //do some basic validation
            //check 
            db_connection.Open();
            SqlCommand sql_command = new SqlCommand("SELECT count(*) FROM flight_details WHERE flight_name ='" + flight_name.Text + "'", db_connection);
            int check = (Int32)sql_command.ExecuteScalar();

            //check for the minimum no of fligts
            if (check > 0)
            {
                MessageBox.Show("Flight Name already exist! ");
                db_connection.Close();
            }
            else
            {
                sql_command.CommandText = " INSERT INTO flight_details(flight_name,flight_weight,arrival_time,departure_time,base_airport,destination_airport) values ('" + flight_name.Text + "','" + flight_weight.Text + "','" + arrival_time.Text + "','" + departure_time.Text + "','" + destination_airport.Text + "','" + base_airport.Text + "')";
                sql_command.ExecuteNonQuery();
                db_connection.Close();
                MessageBox.Show("Flight details successfully recorded");

            }



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void departure_time_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
