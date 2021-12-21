using MySql.Data.MySqlClient;
using SynthesisAssignment.Models;
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

        //add gear
        public bool AddGear(Inventory gear)
        {
            bool status = false;
            try
            {

                object type = null;
                object capacity = null;

                if (gear is Boat)
                {
                    type = ((Boat)gear).BoatType;
                    capacity = ((Boat)gear).Capacity;
                }
                else if (gear is Item)
                {
                    type = ((Item)gear).ItemType;
                }

                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = null;
                if (gear.GetType() == typeof(Boat))
                {

                    sqlQuery = "insert into syn_boat (boat_type, boat_capacity, boat_cost, boat_deposit, boat_quantity, boat_remark) VALUES (@boat_type, @capacity, @cost, @deposit, @quantity, @remark) ";

                }
                else if (gear.GetType() == typeof(Item))
                {
                    sqlQuery = "insert into syn_item (item_type, item_cost, item_deposit, item_quantity, item_remark) VALUES (@item_type, @cost, @deposit, @quantity, @remark) ";
                }

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //if boat
                cmd.Parameters.AddWithValue("@boat_type", type);
                cmd.Parameters.AddWithValue("@capacity", capacity);
                //if item
                cmd.Parameters.AddWithValue("@item_type", type);

                //the rest applies for both
                cmd.Parameters.AddWithValue("@cost", gear.Cost);
                cmd.Parameters.AddWithValue("@deposit", gear.Deposit);
                cmd.Parameters.AddWithValue("@quantity", gear.Quantity);
                cmd.Parameters.AddWithValue("@remark", gear.Remark);

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

        //update gear
        public bool UpdateGear(Inventory gear)
        {
            bool status = false;
            try
            {
                string type = "";
                string capacity = "";

                if (gear is Boat)
                {
                    type = ((Boat)gear).BoatType;
                    capacity = ((Boat)gear).Capacity;
                }
                else if (gear is Item)
                {
                    type = ((Item)gear).ItemType;
                }

                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = null;
                if (gear.GetType() == typeof(Boat))
                {

                    sqlQuery = "update syn_boat set boat_capacity=@capacity, boat_cost=@cost, boat_deposit=@deposit, boat_quantity=@quantity, boat_remark=@remark where boat_type=@boat_type";

                }
                else if (gear.GetType() == typeof(Item))
                {
                    sqlQuery = "update syn_item set item_cost=@cost, item_deposit=@deposit, item_quantity=@quantity, item_remark=@remark where item_type=@item_type";
                }


                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //if boat
                cmd.Parameters.AddWithValue("@boat_type", type);
                cmd.Parameters.AddWithValue("@capacity", capacity);

                //if item
                cmd.Parameters.AddWithValue("@item_type", type);

                //the rest applies for both
                cmd.Parameters.AddWithValue("@cost", gear.Cost);
                cmd.Parameters.AddWithValue("@deposit", gear.Deposit);
                cmd.Parameters.AddWithValue("@quantity", gear.Quantity);
                cmd.Parameters.AddWithValue("@remark", gear.Remark);


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

        //delete gear
        public bool DeleteGear(Inventory gear)
        {
            bool status = false;
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = null;
                if (gear.GetType() == typeof(Boat))
                {
                    sqlQuery = "DELETE FROM `syn_boat` WHERE boat_type=@boat_type";
                } 
                else if (gear.GetType() == typeof(Item))
                {
                    sqlQuery = "DELETE FROM `syn_item` WHERE item_type=@item_type";
                }

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                if (gear is Boat)
                {
                    cmd.Parameters.AddWithValue("@boat_type", ((Boat)gear).BoatType);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@item_type", ((Item)gear).ItemType);
                }

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

        //list of boats
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

        //list of items
        public IEnumerable<Inventory> GetAllItems()
        {

            try
            {
                List<Item> items = new List<Item>();
                Item item = new Item();

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //Query to execute
                string query = "SELECT * from syn_item order by item_ID ASC;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                //read data from DB
                while (dr.Read())
                {
                    
                    string itemType = dr["item_type"].ToString();
                    double itemCost = Convert.ToDouble(dr["item_cost"]);
                    double itemDeposit = Convert.ToDouble(dr["item_deposit"]);
                    int itemQuantity = Convert.ToInt32(dr["item_quantity"]);
                    string itemRemark = dr["item_remark"].ToString();

                    item = new Item(itemType, itemCost, itemDeposit, itemQuantity, itemRemark);

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
            List<Inventory> inventory = new List<Inventory>();

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
