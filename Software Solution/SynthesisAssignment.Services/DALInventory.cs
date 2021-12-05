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
        List<Inventory> inventory = new List<Inventory>();
        ConnectionString SQLConnection = new ConnectionString();

        public bool AddBoat(Boat boat)
        {

            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                string sqlQuery = "insert into syn_boat (boat_type, boat_capacity, boat_cost, boat_deposit, boat_quantity, boat_remark) VALUES (@boat_type, @capacity, @cost, @deposit, @quantity, @remark) ";
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
                throw;
                //return false;
            }
        }


        public bool AddItem(Item item)
        {
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                string sqlQuery = "insert into syn_item (item_type, item_cost, item_deposit, item_quantity, item_remark) VALUES (@item_type, @cost, @deposit, @quantity, @remark) ";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@item_type", item.ItemType.ToString());
                cmd.Parameters.AddWithValue("@cost", item.Cost);

                if (!string.IsNullOrEmpty(item.Deposit.ToString()))
                {
                    cmd.Parameters.AddWithValue("@deposit", item.Deposit);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@deposit", 0);
                }
                
                cmd.Parameters.AddWithValue("@quantity", item.Quantity);

                //if remark is null
                if (!string.IsNullOrEmpty(item.Remark))
                {
                    cmd.Parameters.AddWithValue("@remark", item.Remark);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@remark", "");
                }

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


        public IEnumerable<Inventory> GetAllBoats()
        {

            try
            {
                List<Boat> boats = new List<Boat>();
                Boat boat = new Boat();

                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                //Query to execute
                string query = "SELECT * from syn_boat order by boat_ID ASC;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //all boats
                    boat = new Boat();
                    boat.ID = Convert.ToInt32(dr["boat_ID"]);
                    boat.BoatType = dr["boat_type"].ToString();
                    boat.Capacity = dr["boat_capacity"].ToString();
                    boat.Cost = Convert.ToDouble(dr["boat_cost"]);
                    boat.Deposit = Convert.ToDouble(dr["boat_deposit"]);
                    boat.Quantity = Convert.ToInt32(dr["boat_quantity"]);
                    boat.Remark = dr["boat_remark"].ToString();

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


        public IEnumerable<Inventory> GetAllItems()
        {

            try
            {
                List<Item> items = new List<Item>();
                Item item = new Item();

                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                //Query to execute
                string query = "SELECT * from syn_item order by item_ID ASC;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    //all items
                    item = new Item();
                    item.ID = Convert.ToInt32(dr["item_ID"]);
                    item.ItemType = dr["item_type"].ToString();
                    item.Cost = Convert.ToDouble(dr["item_cost"]);
                    item.Deposit = Convert.ToDouble(dr["item_deposit"]);
                    item.Quantity = Convert.ToInt32(dr["item_quantity"]);
                    item.Remark = dr["item_remark"].ToString();

                    items.Add(item);

                }

                con.Close();
                return items;
            }
            catch (Exception)
            {
                throw;
                //return inventory;
            }
        }


        public IEnumerable<Inventory> GetAllGear()
        {

            inventory.AddRange(GetAllBoats());
            inventory.AddRange(GetAllItems());
            try
            {

                return inventory;
            }
            catch (Exception)
            {
                throw;
                //return inventory;
            }
        }

    }
}
