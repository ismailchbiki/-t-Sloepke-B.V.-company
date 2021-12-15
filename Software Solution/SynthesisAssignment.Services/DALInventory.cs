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

        //add gear
        public bool AddGear(Inventory gear)
        {
            try
            {

                object type = "";
                object capacity = "";

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
                cmd.Parameters.AddWithValue("@boat_type", type.ToString());
                cmd.Parameters.AddWithValue("@capacity", capacity.ToString());
                //if item
                cmd.Parameters.AddWithValue("@item_type", type.ToString());

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

                return true;
            }
            catch (Exception)
            {
                throw;
                //return false;
            }
        }

        //update gear
        public bool UpdateGear(int id, Inventory gear)
        {

            //try
            {
                //object type = "";
                object capacity = "";

                if (gear is Boat)
                {
                    //type = ((Boat)gear).BoatType;
                    capacity = ((Boat)gear).Capacity;
                }
                else if (gear is Item)
                {
                    //type = ((Item)gear).ItemType;
                }


                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = null;
                if (gear.GetType() == typeof(Boat))
                {

                    sqlQuery = "update syn_boat set boat_capacity=@capacity, boat_cost=@cost, boat_deposit=@deposit, boat_quantity=@quantity, boat_remark=@remark where boat_ID=@ID";

                }
                else if (gear.GetType() == typeof(Item))
                {
                    sqlQuery = "update syn_item set item_cost=@cost, item_deposit=@deposit, item_quantity=@quantity, item_remark=@remark where item_ID=@ID";
                }


                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //if boat
                //cmd.Parameters.AddWithValue("@boat_type", type.ToString());
                cmd.Parameters.AddWithValue("@capacity", capacity.ToString());
                //if item
                //cmd.Parameters.AddWithValue("@item_type", type.ToString());

                //the rest applies for both
                cmd.Parameters.AddWithValue("@ID", id);
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

                return true;
            }
            //catch (Exception)
            //{
            //    throw;
            //    //return false;
            //}
        }

        //delete gear
        public bool DeleteGear(Inventory gear)
        {
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

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

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

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

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

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
