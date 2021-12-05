using MySql.Data.MySqlClient;
using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class DALInventory : IDALInventory
    {

        ConnectionString SQLConnection = new ConnectionString();

        public bool AddBoat(Boat boat)
        {

            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                string sqlQuery = "insert into syn_boat (boat_type, capacity, cost, deposit, quantity, remark) VALUES (@boat_type, @capacity, @cost, @deposit, @quantity, @remark) ";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@boat_type", boat.BoatType.ToString());
                cmd.Parameters.AddWithValue("@capacity", boat.Capacity.ToString());
                cmd.Parameters.AddWithValue("@cost", boat.Cost);
                cmd.Parameters.AddWithValue("@deposit", boat.Deposit);
                cmd.Parameters.AddWithValue("@quantity", boat.Quantity);
                cmd.Parameters.AddWithValue("@remark", boat.Remark);
                

                //Open the connection
                con.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Close the connection
                con.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool UpdateBoat(Boat boat)
        {
            throw new NotImplementedException();
        }


        public bool DeleteBoat(int id)
        {
            throw new NotImplementedException();
        }


        public Boat GetBoatByID(int id)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Boat> GetAllBoats()
        {

            List<Boat> boats = new List<Boat>();

            try
            {
                Boat boat = new Boat();

                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                //Query to execute
                string query = "SELECT * from syn_boat order by ID ASC;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    boat = new Boat();
                    boat.ID = Convert.ToInt32(dr["ID"]);
                    boat.BoatType = dr["boat_type"].ToString();
                    boat.Capacity = dr["capacity"].ToString();
                    boat.Cost = Convert.ToDouble(dr["cost"]);
                    boat.Deposit = Convert.ToDouble(dr["deposit"]);
                    boat.Quantity = Convert.ToInt32(dr["quantity"]);
                    boat.Remark = dr["remark"].ToString();

                    boats.Add(boat);
                }
                con.Close();

                return boats;
            }
            catch (Exception)
            {
                return boats;
            }
        }
    }
}
