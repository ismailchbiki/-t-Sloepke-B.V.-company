using MySql.Data.MySqlClient;
using SynthesisAssignment.Models;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.MyClasses.Classes.MyHelpers;
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

                    "INSERT INTO syn_quote (customer_ID, date_of_made, start_date, end_date, location) " +
                    "VALUES((select max(ID) from syn_customer), @dateOfMade, @startDate, @endDate, @location);" +

                    "INSERT INTO syn_boat_description (boat_ID, quantity, quote_ID) " +
                    "VALUES((select boat_ID from syn_boat where boat_type = @boatType), @boatQuantity, (SELECT max(ID) from syn_quote));" +

                    "INSERT INTO syn_item_description (item_ID, quantity, quote_ID) " +
                    "VALUES((select item_ID from syn_item where item_type = @itemType), @itemQuantity, (SELECT max(ID) from syn_quote));";

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
                cmd.Parameters.AddWithValue("@dateOfMade", quote.DateTimeOfMade.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@startDate", quote.StartDateTime.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@endDate", quote.EndDateTime.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@location", quote.Location);

                //boat description
                cmd.Parameters.AddWithValue("@boatType", boat.BoatType.ToString());
                cmd.Parameters.AddWithValue("@boatQuantity", boat.Quantity);

                //boat description
                cmd.Parameters.AddWithValue("@itemType", item.ItemType.ToString());
                cmd.Parameters.AddWithValue("@itemQuantity", item.Quantity);

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

        // get all the quotes and their details
        public IEnumerable<ClassCollection> GetAllQuotes()
        {
            try
            {
                List<ClassCollection> allQuotesDetails = new List<ClassCollection>();
                ClassCollection quoteDetails = new ClassCollection();

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //Query to execute
                string query = "SELECT syn_quote.ID as Quote_ID, `first_name`, `last_name`, `address`, `zipcode`, `city`, `phone`, `email`, " +
                    "`date_of_made`, `start_date`, `end_date`, `location`, " +
                    "b.boat_type, b.boat_cost, b.boat_deposit, b_d.quantity as boat_quantity, " +
                    "i.item_type, i.item_cost, i.item_deposit, i_d.quantity as item_quantity FROM `syn_customer` " +
                    "inner join syn_quote on syn_customer.ID = syn_quote.customer_ID INNER JOIN syn_boat_description as b_d on b_d.quote_ID = syn_quote.ID " +
                    "INNER JOIN syn_item_description as i_d on i_d.quote_ID = syn_quote.ID INNER JOIN syn_boat as b on b_d.boat_ID = b.boat_ID " +
                    "INNER JOIN syn_item as i on i.item_ID = i_d.item_ID;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    //customer details
                    quoteDetails.Customer.FirstName = dr["first_name"].ToString();
                    quoteDetails.Customer.LastName = dr["last_name"].ToString();
                    quoteDetails.Customer.Address = dr["address"].ToString();
                    quoteDetails.Customer.Zipcode = dr["zipcode"].ToString();
                    quoteDetails.Customer.City = dr["city"].ToString();
                    quoteDetails.Customer.Phone = Convert.ToInt32(dr["phone"]);
                    quoteDetails.Customer.Email = dr["email"].ToString();

                    //quote details
                    quoteDetails.Quote = new Quote(Convert.ToInt32(dr["Quote_ID"]));
                    quoteDetails.Quote.DateTimeOfMade = Convert.ToDateTime(dr["date_of_made"]);
                    quoteDetails.Quote.StartDateTime = Convert.ToDateTime(dr["start_date"]);
                    quoteDetails.Quote.EndDateTime = Convert.ToDateTime(dr["end_date"]);
                    quoteDetails.Quote.Location = dr["location"].ToString();

                    //boat details
                    quoteDetails.Boat.BoatType = dr["boat_type"].ToString();
                    quoteDetails.Boat.Cost = Convert.ToDouble(dr["boat_cost"]);
                    quoteDetails.Boat.Deposit = Convert.ToDouble(dr["boat_deposit"]);
                    quoteDetails.Boat.Quantity = Convert.ToInt32(dr["boat_quantity"]);

                    //item details
                    quoteDetails.Item.ItemType = dr["item_type"].ToString();
                    quoteDetails.Item.Cost = Convert.ToDouble(dr["item_cost"]);
                    quoteDetails.Item.Deposit = Convert.ToDouble(dr["item_deposit"]);
                    quoteDetails.Item.Quantity = Convert.ToInt32(dr["item_quantity"]);

                    allQuotesDetails.Add(quoteDetails);
                }

                con.Close();

                return allQuotesDetails;
            }
            
            catch (Exception)
            {
                throw;
                //return inventory;
            }
        }
    }
}
