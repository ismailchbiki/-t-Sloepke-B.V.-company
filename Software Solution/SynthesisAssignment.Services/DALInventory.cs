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


        //add new boat
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

        //update boat
        public bool UpdateBoat(int id, Boat boat)
        {
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                string sqlQuery = "update syn_boat set boat_type=@boat_type, boat_capacity=@boat_capacity, boat_cost=@boat_cost, boat_deposit=@boat_deposit, boat_quantity=@boat_quantity, boat_remark=@boat_remark where boat_ID=@boat_ID";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@boat_ID", id);
                cmd.Parameters.AddWithValue("@boat_type", boat.BoatType.ToString());
                cmd.Parameters.AddWithValue("@boat_capacity", boat.Capacity.ToString());
                cmd.Parameters.AddWithValue("@boat_cost", boat.Cost);
                cmd.Parameters.AddWithValue("@boat_deposit", boat.Deposit);
                cmd.Parameters.AddWithValue("@boat_quantity", boat.Quantity);
                cmd.Parameters.AddWithValue("@boat_remark", boat.Remark);


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

        //add new item
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
                throw;
            }
        }

        //update item
        public bool UpdateItem(int id, Item item)
        {
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                string sqlQuery = "update syn_item set item_type=@item_type, item_cost=@item_cost, item_deposit=@item_deposit, item_quantity=@item_quantity, item_remark=@item_remark where item_ID=@item_ID";
                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@item_ID", id);
                cmd.Parameters.AddWithValue("@item_type", item.ItemType.ToString());
                cmd.Parameters.AddWithValue("@item_cost", item.Cost);
                cmd.Parameters.AddWithValue("@item_deposit", item.Deposit);
                cmd.Parameters.AddWithValue("@item_quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@item_remark", item.Remark);


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

        //delete gear
        public bool DeleteGear(Inventory gear)
        {
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                string sqlQuery = null;
                if (gear.GetType() == typeof(Boat))
                {
                    sqlQuery = "DELETE FROM `syn_boat` WHERE boat_ID=@ID";
                } 
                else if (gear.GetType() == typeof(Item))
                {
                    sqlQuery = "DELETE FROM `syn_item` WHERE item_ID=@ID";
                }

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@ID", gear.ID);

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

        //list of boats
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

        //list of items
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

        //list of all gear
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
