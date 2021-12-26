using MySql.Data.MySqlClient;
using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class DALBoat : IDALBoat
    {
        public bool AddGear(Inventory boat)
        {
            bool status = false;
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "insert into syn_boat (boat_type, boat_capacity, boat_cost, boat_deposit, boat_quantity, boat_remark) VALUES (@boat_type, @capacity, @cost, @deposit, @quantity, @remark) ";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //if boat
                cmd.Parameters.AddWithValue("@boat_type", ((Boat)boat).BoatType);
                cmd.Parameters.AddWithValue("@capacity", ((Boat)boat).Capacity);
                cmd.Parameters.AddWithValue("@cost", boat.UnitCost);
                cmd.Parameters.AddWithValue("@deposit", boat.Deposit);
                cmd.Parameters.AddWithValue("@quantity", boat.Quantity);
                cmd.Parameters.AddWithValue("@remark", boat.Remark);

                //Open the connection
                con.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Close the connection
                con.Close();

                status = true;
                return status;
            }
            catch (Exception)
            {
                //return status;
                throw;
            }
        }

        public bool DeleteGear(Inventory boat)
        {
            bool status = false;
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "DELETE FROM `syn_boat` WHERE boat_type=@boat_type";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@boat_type", ((Boat)boat).BoatType);

                //Open the connection
                con.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Close the connection
                con.Close();

                status = true;
                return status;
            }
            catch (Exception)
            {
                //return status;
                throw;
            }
        }

        public IEnumerable<Inventory> GetAllBoats()
        {
            try
            {
                List<Boat> boats = new List<Boat>();
                Boat boat = new Boat();

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //Query to execute
                string query = "SELECT * from syn_boat order by boat_ID ASC;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                //read data from db
                while (dr.Read())
                {

                    string bType = dr["boat_type"].ToString();
                    string capacity = dr["boat_capacity"].ToString();
                    double boatCost = Convert.ToDouble(dr["boat_cost"]);
                    double boatDeposit = Convert.ToDouble(dr["boat_deposit"]);
                    int boatQuantity = Convert.ToInt32(dr["boat_quantity"]);
                    string boatRemark = dr["boat_remark"].ToString();

                    boat = new Boat(bType, capacity, boatCost, boatDeposit, boatQuantity, boatRemark);

                    boats.Add(boat);
                }

                con.Close();

                return boats;
            }
            catch (Exception)
            {
                throw;
                //return inventory;
            }
        }

        public bool UpdateGear(Inventory boat)
        {
            bool status = false;
            try
            {

                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "update syn_boat set boat_capacity=@capacity, boat_cost=@cost, boat_deposit=@deposit, boat_quantity=@quantity, boat_remark=@remark where boat_type=@boat_type";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@boat_type", ((Boat)boat).BoatType);
                cmd.Parameters.AddWithValue("@capacity", ((Boat)boat).Capacity);
                cmd.Parameters.AddWithValue("@cost", boat.UnitCost);
                cmd.Parameters.AddWithValue("@deposit", boat.Deposit);
                cmd.Parameters.AddWithValue("@quantity", boat.Quantity);
                cmd.Parameters.AddWithValue("@remark", boat.Remark);

                //Open the connection
                con.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Close the connection
                con.Close();

                status = true;
                return status;
            }
            catch (Exception)
            {
                //return status;
                throw;
            }
        }
    }
}
