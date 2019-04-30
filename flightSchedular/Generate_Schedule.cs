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
    public partial class Generate_Schedule : UserControl
    {

        //connect to db
        SqlConnection db_connection = new SqlConnection("Data Source=VITALIS;Initial Catalog=FlightSchedule; MultipleActiveResultSets=true;Integrated Security=True");
       

        public Generate_Schedule()
        {
           
            InitializeComponent();
            schedule_message.Visible = true;
            schedule_display.Visible = false;
        }

        private void generate_new_schedule_btn_Click(object sender, EventArgs e)
        {
            schedule_message.Visible = false;
            schedule_display.Visible = true;

            db_connection.Open();

            //check for number of flights avaliable
            SqlCommand sql_command = new SqlCommand("SELECT count(*) FROM flight_details", db_connection);
            int check = (Int32)sql_command.ExecuteScalar();

            //check the weather
            SqlCommand get_weather = new SqlCommand("SELECT * FROM weather", db_connection);
            SqlDataReader read_weather = get_weather.ExecuteReader();
            
            //check for the minimum no of flights
            if (check < 10)
            {
                MessageBox.Show("You must have at least 10 flights to schedule, You only have   " + check.ToString());
                db_connection.Close();
            }
            else if (!read_weather.Read())
            {
                MessageBox.Show("Set Weather Condition First, before scheduling flights");
                db_connection.Close();
            }
            else if (read_weather["action"].ToString() == "NO"){

                MessageBox.Show("The weather is bad, Flights cannot be scheduled");
                db_connection.Close();
            }
            else
            {
                //now select 10 samples from the database
               
                string query = "SELECT TOP 10 flight_name FROM flight_details ORDER by id DESC";
                SqlDataAdapter flights = new SqlDataAdapter(query, db_connection);
                DataTable data = new DataTable();
                flights.Fill(data);
               
                //now create a parent, as a list
                List<String> parents = new List<string>();

                //the loop and add to a list
                foreach(DataRow row in data.Rows)
                {
                    parents.Add(row["flight_name"].ToString());
                   /// MessageBox.Show(row["flight_name"].ToString());
                }

                //generate 10 more different parents(population)
                var rand_0 = new Random();
                var parent_0 = parents.OrderBy(item => rand_0.Next(2));

                var rand_1 = new Random();
                var parent_1 = parents.OrderBy(item => rand_1.Next(17));

                var rand_2 = new Random();
                var parent_2 = parents.OrderBy(item => rand_2.Next(13));

                var rand_3 = new Random();
                var parent_3 = parents.OrderBy(item => rand_1.Next(11));

                var rand_4 = new Random();
                var parent_4 = parents.OrderBy(item => rand_1.Next(7));

                var rand_5 = new Random();
                var parent_5 = parents.OrderBy(item => rand_1.Next(30));

                var rand_6 = new Random();
                var parent_6 = parents.OrderBy(item => rand_1.Next(33));

                var rand_7 = new Random();
                var parent_7 = parents.OrderBy(item => rand_1.Next(20));

                var rand_8 = new Random();
                var parent_8 = parents.OrderBy(item => rand_1.Next(27));

                var rand_9 = new Random();
                var parent_9 = parents.OrderBy(item => rand_1.Next(25));

                var rand_10 = new Random();
                var parent_10 = parents.OrderBy(item => rand_1.Next(39));

                //check for fitness(arrival time and big, medium and small flights)
                List<List<string>> allParents = new List<List<string>>();
                allParents.Add(parent_1.ToList<string>());
                allParents.Add(parent_2.ToList<string>());
                allParents.Add(parent_3.ToList<string>());
                allParents.Add(parent_4.ToList<string>());
                allParents.Add(parent_5.ToList<string>());
                allParents.Add(parent_6.ToList<string>());

                allParents.Add(parent_7.ToList<string>());
                allParents.Add(parent_8.ToList<string>());
                allParents.Add(parent_9.ToList<string>());
                allParents.Add(parent_10.ToList<string>());

                //then loop through the lists of lists and assign fitness values
                SortedList<string, int> mySortedList = new SortedList<string, int>();
               

                int fitness = 10;
                string initial_size = "";
                int initial_add = 0;
                int parent_no = 0;


                foreach (List<string> parent in allParents)
                {
                    
                    foreach (string flight in parent)
                    {

                        //db_connection.Open();
                       
                        SqlCommand get_flights = new SqlCommand("SELECT TOP 1 flight_weight FROM flight_details WHERE flight_name ='"+ flight + "' Order by id DESC", db_connection);
                        SqlDataReader read_flights = get_flights.ExecuteReader();

                        //catch the size of the first guy
                        if (read_flights.Read() && initial_add == 0)
                        {
                           // best_parent1.Add(read_flights["flight_details"].ToString());
                            initial_size = read_flights["flight_weight"].ToString();
                            initial_add++;
                        }
                            //check the size of the second guy
                            if(initial_add != 0 && read_flights["flight_weight"].ToString() == initial_size)
                            {
                                fitness--;
                                initial_add++;
                                //set the initial size to be this size
                                initial_size =read_flights["flight_weight"].ToString();
                            }
                            else {
                                    initial_add++;
                                    //set the initial size to be this size
                                    initial_size = read_flights["flight_weight"].ToString();
                            }
                        //after this create a dictionary with the parent name and save the fitness
                        if(initial_add >= 9)
                        {
                            //add all into a sorted list and from here select the best two parents
                            mySortedList.Add("parent_" + parent_no,fitness);
                            //MessageBox.Show("parent_"+ parent_no+ "has a fitness of"+ fitness );
                            parent_no = parent_no + 1;

                            //reset the fitness again
                            fitness = 10;
                            break;
                        }
                      

                    }
                }

                //Then I reverse the sorted list
                var orderByGrade = mySortedList.OrderBy(kvp => kvp.Value);
                //then i created a new list and added the keys

                List<string> newList = new List<string>();
                foreach (var values in orderByGrade)
                {
                    newList.Add(values.Key.ToString());
                }
               

                
               
                

                //MessageBox.Show(newList.Count().ToString());
                int last_index = newList.Count() - 1;
                int last_index_x = last_index - 1;
                IEnumerable<object> best_parent_1 = null;
                IEnumerable<object> best_parent_2 = null;

                //select the best two fit parents, from the sorted list
                if (newList[last_index] == "parent_0")
                {
                     best_parent_1 = parent_0;
                }
                else if (newList[last_index] == "parent_1")
                {
                     best_parent_1 = parent_1;
                }
                 else if (newList[last_index] == "parent_2")
                {
                    best_parent_1 = parent_2;
                }
                else if (newList[last_index] == "parent_3")
                {
                    best_parent_1 = parent_3;
                }
                else if (newList[last_index] == "parent_4")
                {
                    best_parent_1 = parent_4;
                }
                else if (newList[last_index] == "parent_5")
                {
                    best_parent_1 = parent_5;
                }
                else if (newList[last_index] == "parent_6")
                {
                    best_parent_1 = parent_6;
                }
                else if (newList[last_index] == "parent_7")
                {
                    best_parent_1 = parent_7;
                }
                else if (newList[last_index] == "parent_8")
                {
                    best_parent_1 = parent_8;
                }
                else
                {
                    best_parent_1 = parent_9;
                }

                //select the second best parent
              
                if (newList[last_index_x] == "parent_0")
                {
                    best_parent_2 = parent_0;
                }
                else if (newList[last_index_x] == "parent_1")
                {
                    best_parent_2 = parent_1;
                }
                else if (newList[last_index_x] == "parent_2")
                {
                    best_parent_2 = parent_2;
                }
                else if (newList[last_index_x] == "parent_3")
                {
                    best_parent_2 = parent_3;
                }
                else if (newList[last_index_x] == "parent_4")
                {
                    best_parent_2 = parent_4;
                }
                else if (newList[last_index_x] == "parent_5")
                {
                    best_parent_2 = parent_5;
                }
                else if (newList[last_index_x] == "parent_6")
                {
                    best_parent_2 = parent_6;
                }
                else if (newList[last_index_x] == "parent_7")
                {
                    best_parent_2 = parent_7;
                }
                else if (newList[last_index_x] == "parent_8")
                {
                    best_parent_2 = parent_8;
                }
                else
                {
                    best_parent_2 = parent_9;
                }
               

                
                //foreach (var ee in best_parent_1)
                //{
                //    MessageBox.Show(ee.ToString());
                //}


                //crossover
                //get the first five itemes from best_parent_1 and add to the child
                List<string> child = new List<string>();
                int count = 0;

                foreach (var element in best_parent_1)
                {
                    if (count <= 4)
                    {
                        child.Add(element.ToString());
                    }
                   else
                   {
                       break;
                   }
                    count++;
               }

                //also pick from the parent_2 and add to the child
               foreach (var element in best_parent_2)
                {
                    if (!child.Contains(element.ToString()))
                   {
                       child.Add(element.ToString());
                   }
                }

                ////Mutation
                ////then I will mutate the child element
                var child_rand = new Random();
                var best_child = child.OrderBy(item => child_rand.Next());
               
                //insert what i have to database,
                //for big flights,the spend 30 mins on the runway,medium spends, 20mins and small spends 10 mins 

                DateTime current_time = DateTime.Now;
                DateTime start_time = DateTime.Now;
                DateTime end_time = DateTime.Now;
                int start_count = 0;

                //clear everything in the table before
                SqlCommand delete_flys = new SqlCommand("DELETE FROM scheduled_flight", db_connection);
                SqlDataReader read_flys = delete_flys.ExecuteReader();


                foreach (var element in best_child)
                {
                    SqlCommand get_flights_now = new SqlCommand("SELECT TOP 1 * FROM flight_details WHERE flight_name ='" + element + "' Order by id DESC", db_connection);
                    SqlDataReader s_f = get_flights_now.ExecuteReader();
                    String total_time = null;
                    ////if there is anything selected, add it to the scheduled flights database
                    if (s_f.Read())
                    {
                        if (s_f["flight_weight"].ToString() == "B" || s_f["flight_weight"].ToString() == "Big")
                        {
                        
                             total_time = "30 minutes";
                        }
                        else if (s_f["flight_weight"].ToString() == "M" || s_f["flight_weight"].ToString() == "Medium")
                        {
                           
                            total_time = "20 minutes";
                        }
                        else
                        {
                           
                            total_time = "10 minutes";
                        }

                        //then catch the start and end time
                        if (start_count == 0)
                        {
                            if (s_f["flight_weight"].ToString() == "B" || s_f["flight_weight"].ToString() == "Big")
                            {
                                start_time = current_time;
                                end_time = current_time.AddMinutes(30);
                                start_count++;

                            }
                            else if (s_f["flight_weight"].ToString() == "M" || s_f["flight_weight"].ToString() == "Medium")
                            {
                                start_time = current_time;
                                end_time = current_time.AddMinutes(20);
                                start_count++;
                            }
                            else
                            {
                                start_time = current_time;
                                end_time = current_time.AddMinutes(10);
                                start_count++;

                            }
                        }
                        else
                        {
                            if (s_f["flight_weight"].ToString() == "B" || s_f["flight_weight"].ToString() == "Big")
                            {
                                start_time = end_time;
                                end_time = end_time.AddMinutes(30);
                                start_count++;

                            }
                            else if (s_f["flight_weight"].ToString() == "M" || s_f["flight_weight"].ToString() == "Medium")
                            {
                                start_time = end_time;
                                end_time = end_time.AddMinutes(20);
                                start_count++;
                            }
                            else
                            {
                                start_time = end_time;
                                end_time = end_time.AddMinutes(10);
                                start_count++;

                            }
                        }
                        


                        //then insert data to the scheduled flights table
                        sql_command.CommandText = " INSERT INTO scheduled_flight(flight_name,flight_weight,base_airport,destination_airport,total_alloted_time,date_scheduled,start_time,stop_time) values ('" + s_f["flight_name"] + "','" + s_f["flight_weight"] + "','" + s_f["base_airport"] + "','" + s_f["destination_airport"] + "','" + total_time + "','"+ current_time+ "','" + start_time + "','" + end_time + "')";
                        sql_command.ExecuteNonQuery();
                       // MessageBox.Show("Success");

                    }
                    else
                    {
                        MessageBox.Show("Flight scheduling failed");
                    }
                }

                schedule_message.Visible = false;
                schedule_display.Visible = true;

                MessageBox.Show("Flight schedule successfully generated");
                string display_flights = "SELECT * FROM scheduled_flight";
                SqlDataAdapter flights_d = new SqlDataAdapter(display_flights, db_connection);
                DataTable data_d = new DataTable();
                flights_d.Fill(data_d);
                schedule_display.DataSource = data_d;




                db_connection.Close();



            }
           
           

           // db_connection.Close();
        }

        private void view_previous_schedule_btn_Click(object sender, EventArgs e)
        {
            schedule_message.Visible = false;
            schedule_display.Visible = true;

            db_connection.Open();
            string query = "SELECT * FROM scheduled_flight";
            SqlDataAdapter flights = new SqlDataAdapter(query, db_connection);
            DataTable data = new DataTable();
            flights.Fill(data);
            schedule_display.DataSource = data;
            db_connection.Close();
        }

        private void delete_previous_schedules_btn_Click(object sender, EventArgs e)
        {
            db_connection.Open();

            SqlCommand delete_flights = new SqlCommand("DELETE FROM scheduled_flight", db_connection);
            SqlDataReader read_flights = delete_flights.ExecuteReader();
            MessageBox.Show("Flight successfully deleted");
             
            db_connection.Close();
        }

        private void schedule_display_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void schedule_message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
