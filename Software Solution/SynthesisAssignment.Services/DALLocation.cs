using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class DALLocation : IDALLocation
    {
        public IEnumerable<string> GelAllLocations()
        {
            try
            {
                List<string> locations = new List<string>();

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //Query to execute
                string query = "SELECT * from syn_location;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                //read data from db
                while (dr.Read())
                {
                    string location = dr["location"].ToString();


                    locations.Add(location);
                }

                con.Close();

                return locations;
            }
            catch (Exception)
            {
                throw;
                //return inventory;
            }
        }
    }
}
