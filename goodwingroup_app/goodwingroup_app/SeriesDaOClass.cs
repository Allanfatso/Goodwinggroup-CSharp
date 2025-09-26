using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;

namespace goodwingroup_app
{

    internal class SeriesDaOClass
    {

        string connectionstring = "Data Source=localhost;port=3306;username=root;password=Drivingsupportworker@2520;database=tv_library;";

        public List<SeriesClass> GetallSeries()
        {

            List<SeriesClass> returnThese = new List<SeriesClass>();
            //connect to mysql database and return all series
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();
            
            MySqlCommand command = new MySqlCommand("SELECT * FROM series", connection);

            using(MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SeriesClass s = new SeriesClass
                    {
                        ID = reader.GetInt32(0),
                        series_title = reader.GetString(1),
                        series_genre = reader.GetString(2),
                        year = reader.GetInt32(3),
                        image_name = reader.GetString(4),
                        description = reader.GetString(5),
                       
                    };

                    s.seasons = getSeasons(s.ID);

                    returnThese.Add(s);
                }
            }

            connection.Close();

            return returnThese;
        }

        public List<SeriesClass> searchTitles(String searchTerm)
        {

            List<SeriesClass> returnThese = new List<SeriesClass>();
            //connect to mysql database and return all series
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM series WHERE series_title LIKE @searchTerm";
            command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    SeriesClass s = new SeriesClass
                    {
                        ID = reader.GetInt32(0),
                        series_title = reader.GetString(1),
                        series_genre = reader.GetString(2),
                        year = reader.GetInt32(3),
                        image_name = reader.GetString(4),
                        description = reader.GetString(5),

                    };
                    returnThese.Add(s);
                }
            }

            connection.Close();

            return returnThese;
        }

        internal int addSeries(SeriesClass serie)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            MySqlCommand command = new MySqlCommand("INSERT INTO `series`(`series_title`, `series_genre`, `year`, `image_name`, `description`) VALUES (@series, @genre, @year, @image, @descr)", connection);

            command.Parameters.AddWithValue("@series", serie.series_title);
            command.Parameters.AddWithValue("@genre", serie.series_genre);
            command.Parameters.AddWithValue("@year", serie.year);
            command.Parameters.AddWithValue("@image", serie.image_name);
            command.Parameters.AddWithValue("@descr", serie.description);
            int result = command.ExecuteNonQuery();


            connection.Close();

            return result;
        }

        public List<Seasons> getSeasons(int seriesid)
        {

            List<Seasons> returnThese = new List<Seasons>();
            //connect to mysql database and return all series
            MySqlConnection connection = new MySqlConnection(connectionstring);
            connection.Open();

            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM seasons WHERE series_id = @seriesid";
            command.Parameters.AddWithValue("@seriesid", seriesid);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Seasons s = new Seasons
                    {
                       ID = reader.GetInt32(0),
                       series_id = reader.GetInt32(1),
                       seasonTitle = reader.GetString(2),
                       description = reader.GetString(3),
                       trailer = reader.GetString(4),


                    };
                    returnThese.Add(s);
                }
            }

            connection.Close();

            return returnThese;
        }



    }


}
