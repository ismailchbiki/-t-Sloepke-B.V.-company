using MySql.Data.MySqlClient;
using SynthesisAssignment.Models;
using SynthesisAssignment.MyClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class DALQuote
    {
        public bool AddQuote(Quote quote, Customer rentor)
        {

            ConnectionString SQLConnection = new ConnectionString();

            try
            {

                //object type = "";
                //object capacity = "";

                //if (gear is Boat)
                //{
                //    type = ((Boat)gear).BoatType;
                //    capacity = ((Boat)gear).Capacity;
                //}
                //else if (gear is Item)
                //{
                //    type = ((Item)gear).ItemType;
                //}


                //connection string
                MySqlConnection con = new MySqlConnection(SQLConnection.MyConnection());

                //string sqlQuery = null;
                //if (gear.GetType() == typeof(Boat))
                //{

                //    sqlQuery = "INSERT INTO `syn_quote`(`customer_ID`, `date_of_made`, `start_date`, `end_date`, `duration`, `location`, `total_price`) " +
                //        "VALUES (@customerID, @dateOfMade, @startDate, @endDate, @duration, @location, @totalPride)";

                //}
                //else if (gear.GetType() == typeof(Item))
                //{
                //    sqlQuery = "insert into syn_item (item_type, item_cost, item_deposit, item_quantity, item_remark) VALUES (@item_type, @cost, @deposit, @quantity, @remark) ";
                //}

                string sqlQuery = "INSERT INTO `syn_customer`(`first_name`, `last_name`, `address`, `zipcode`, `city`, `phone`, `email`) VALUES " +
                    "(@firstname, @lastname, @address, @zipcode, @city, @phone, @email); " +

                    "INSERT INTO `syn_quote`(`customer_ID`, `date_of_made`, `start_date`, `end_date`, `duration`, `location`, `total_price`) " +
                    "VALUES ((SELECT MAX(ID) from syn_customer), @dateOfMade, @startDate, @endDate, @duration, @location, @totalPrice);";


                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //if boat
                //cmd.Parameters.AddWithValue("@customerID", type.ToString());
                //cmd.Parameters.AddWithValue("@capacity", capacity.ToString());
                ////if item
                //cmd.Parameters.AddWithValue("@item_type", type.ToString());

                ////the rest applies for both
                //cmd.Parameters.AddWithValue("@cost", gear.Cost);
                //cmd.Parameters.AddWithValue("@deposit", gear.Deposit);
                //cmd.Parameters.AddWithValue("@quantity", gear.Quantity);
                //cmd.Parameters.AddWithValue("@remark", gear.Remark);


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

            return false;
        }
    }
}
