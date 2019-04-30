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
    public partial class view_all_flights : UserControl
    {
        //connect to db
        SqlConnection db_connection = new SqlConnection("Data Source=VITALIS;Initial Catalog=FlightSchedule;MultipleActiveResultSets=true; Integrated Security=True");
        SqlCommand sql_command = new SqlCommand();

        public view_all_flights()
        {
            InitializeComponent();

            registered_flights();
        }

        private void ViewFlights_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            registered_flights();
        }

        private void registered_flights()
        {
            db_connection.Open();
            string query = "SELECT * FROM flight_details";
            SqlDataAdapter flights = new SqlDataAdapter(query, db_connection);
            DataTable data = new DataTable();
            flights.Fill(data);
            ViewFlights.DataSource = data;
            db_connection.Close();
        }

        private void delete_flight_Click(object sender, EventArgs e)
        {
            db_connection.Open();
            //check 
            SqlCommand sql_command = new SqlCommand("SELECT count(*) FROM flight_details WHERE id ='" + flight_id.Text + "' ", db_connection);
            int check = (Int32)sql_command.ExecuteScalar();

            if(check < 1)
            {
                MessageBox.Show("Enter a valid flight ID to delete");
                db_connection.Close();
            }
            else
            {
                SqlCommand get_flights = new SqlCommand("DELETE FROM flight_details WHERE id ='" + flight_id.Text + "'", db_connection);
                SqlDataReader read_flights = get_flights.ExecuteReader();
                MessageBox.Show("Flight successfully deleted");
                flight_id.Clear();
                db_connection.Close();

            }

           
           
        }
    }
}
