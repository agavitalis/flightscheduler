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
    public partial class weather : UserControl
    {
        //connect to db
        SqlConnection db_connection = new SqlConnection("Data Source=VITALIS;Initial Catalog=FlightSchedule;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand sql_command = new SqlCommand();

        public weather()
        {
            InitializeComponent();
        }

        private void weather_Load(object sender, EventArgs e)
        {
            sql_command.Connection = db_connection;
        }

        private void humidy_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bright_btn_Click(object sender, EventArgs e)
        {
            db_connection.Open();

            try
            {
                SqlCommand delete_weather = new SqlCommand("DELETE FROM weather", db_connection);
                SqlDataReader read_weather = delete_weather.ExecuteReader();
               // MessageBox.Show("Weather successfully deleted");
            }
            finally
            {
                sql_command.CommandText = " INSERT INTO weather(weather_condition,action,description) values ('BRIGHT','YES','Perfect weather, good for air planes')";
                sql_command.ExecuteNonQuery();
                db_connection.Close();
                label_weather.Text= "The weather is bright, you can schedule flights! Enjoy.";
                MessageBox.Show("Weather condition successfully updated");
            }
           
        }

        private void humid_btn_Click(object sender, EventArgs e)
        {
            db_connection.Open();

            try
            {
                SqlCommand delete_weather = new SqlCommand("DELETE FROM weather", db_connection);
                SqlDataReader read_weather = delete_weather.ExecuteReader();
                //MessageBox.Show("Weather successfully deleted");
            }
            finally
            {
                

                sql_command.CommandText = " INSERT INTO weather(weather_condition,action,description) values ('HUMID','NO','Opps, Bad weather not good for air planes')";
                sql_command.ExecuteNonQuery();
                db_connection.Close();
                label_weather.Text = "The weather is humid, you cannot schedule flights, because of poor visibility!.";
                MessageBox.Show("Weather condition successfully updated");
            }
           
        }

        private void rainy_btn_Click(object sender, EventArgs e)
        {
            db_connection.Open();
            try
            {
                SqlCommand delete_weather = new SqlCommand("DELETE FROM weather", db_connection);
                SqlDataReader read_weather = delete_weather.ExecuteReader();
               // MessageBox.Show("Weather successfully deleted");
            }
            finally
            {
                sql_command.CommandText = " INSERT INTO weather(weather_condition,action,description) values ('RAINY','NO','Opps, Bad weather not good for air planes')";
                sql_command.ExecuteNonQuery();
                db_connection.Close();
                label_weather.Text = "Oops, its raining! Flights cannot be scheduled.Please lets play safe";
                MessageBox.Show("Weather condition successfully updated");
            }
            
        }

        private void clear_weather_btn_Click(object sender, EventArgs e)
        {
            db_connection.Open();

            SqlCommand delete_weather = new SqlCommand("DELETE FROM weather", db_connection);
            SqlDataReader read_weather = delete_weather.ExecuteReader();
            MessageBox.Show("Weather successfully deleted");

            db_connection.Close();
        }
    }
}
