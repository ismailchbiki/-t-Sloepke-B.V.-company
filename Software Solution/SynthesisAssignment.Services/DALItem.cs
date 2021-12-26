using MySql.Data.MySqlClient;
using SynthesisAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class DALItem : IDALItem
    {
        public bool AddGear(Inventory item)
        {
            bool status = false;
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "insert into syn_item (item_type, item_cost, item_deposit, item_quantity, item_remark) VALUES (@item_type, @cost, @deposit, @quantity, @remark) ";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //if boat
                cmd.Parameters.AddWithValue("@item_type", ((Boat)item).BoatType);
                cmd.Parameters.AddWithValue("@cost", item.UnitCost);
                cmd.Parameters.AddWithValue("@deposit", item.Deposit);
                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@remark", item.Remark);

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

        public bool DeleteGear(Inventory item)
        {
            bool status = false;
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "DELETE FROM `syn_item` WHERE item_type=@item_type";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@item_type", ((Item)item).ItemType);

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

        public bool UpdateGear(Inventory item)
        {
            bool status = false;
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "update syn_item set item_cost=@cost, item_deposit=@deposit, item_quantity=@quantity, item_remark=@remark where item_type=@item_type";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@item_type", ((Item)item).ItemType);

                //the rest applies for both
                cmd.Parameters.AddWithValue("@cost", item.UnitCost);
                cmd.Parameters.AddWithValue("@deposit", item.Deposit);
                cmd.Parameters.AddWithValue("@quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@remark", item.Remark);


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
