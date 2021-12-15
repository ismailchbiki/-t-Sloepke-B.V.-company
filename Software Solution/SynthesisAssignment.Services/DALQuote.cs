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
    public class DALQuote : IDALQuote
    {

        public bool AddQuote(Customer customer, Boat boat, Item item, Quote quote)
        {
            try
            {

                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //customer, quote, boat, and item details
                string sqlQuery = "INSERT INTO syn_customer (first_name, last_name, address, zipcode, city, phone, email) " +
                    "VALUES(@firstname, @lastname, @address, @zipcode, @city, @phone, @email);" +

                    "INSERT INTO syn_quote (customer_ID, date_of_made, start_date, end_date, location, total_price) " +
                    "VALUES((select max(ID) from syn_customer), @dateOfMade, @startDate, @endDate, @location, @totalPrice);" +

                    "INSERT INTO syn_boat_description (boat_ID, quantity, duration, price, quote_ID) " +
                    "VALUES((select boat_ID from syn_boat where boat_type = @boatType), @boatQuantity, @boatDuration, @boatPrice, (SELECT max(ID) from syn_quote));" +

                    "INSERT INTO syn_item_description (item_ID, quantity, duration, price, quote_ID) " +
                    "VALUES((select item_ID from syn_item where item_type = @itemType), @itemQuantity, @itemDuration, @itemPrice, (SELECT max(ID) from syn_quote));";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //customer details
                cmd.Parameters.AddWithValue("@firstname", customer.FirstName);
                cmd.Parameters.AddWithValue("@lastname", customer.LastName);
                cmd.Parameters.AddWithValue("@address", customer.Address);
                cmd.Parameters.AddWithValue("@zipcode", customer.Zipcode);
                cmd.Parameters.AddWithValue("@city", customer.City);
                cmd.Parameters.AddWithValue("@phone", customer.Phone);
                cmd.Parameters.AddWithValue("@email", customer.Email);

                //quote details
                cmd.Parameters.AddWithValue("@dateOfMade", quote.DateOfMade.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@startDate", quote.StartDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@endDate", quote.EndDate.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@location", quote.Location);
                cmd.Parameters.AddWithValue("@totalPrice", quote.TotalPrice);

                //boat description
                cmd.Parameters.AddWithValue("@boatType", boat.BoatType.ToString());
                cmd.Parameters.AddWithValue("@boatQuantity", boat.Quantity);
                cmd.Parameters.AddWithValue("@boatDuration", boat.Duration);
                cmd.Parameters.AddWithValue("@boatPrice", boat.PriceSemiTotal);

                //boat description
                cmd.Parameters.AddWithValue("@itemType", item.ItemType.ToString());
                cmd.Parameters.AddWithValue("@itemQuantity", item.Quantity);
                cmd.Parameters.AddWithValue("@itemDuration", item.Duration);
                cmd.Parameters.AddWithValue("@itemPrice", item.PriceSemiTotal);                

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
    }
}
