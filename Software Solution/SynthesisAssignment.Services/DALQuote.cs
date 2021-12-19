using MySql.Data.MySqlClient;
using SynthesisAssignment.Models;
using SynthesisAssignment.Models.Enums;
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
        
        public bool AddQuote(Quote quote)
        {
            try
            {

                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //customer, quote, boat, and item details
                string sqlQuery = "START TRANSACTION;" +
                    "INSERT INTO syn_customer (first_name, last_name, address, zipcode, city, phone, email) " +
                    "VALUES(@firstname, @lastname, @address, @zipcode, @city, @phone, @email);" +

                    "INSERT INTO syn_quote (customer_ID, date_of_made, start_date, end_date, location, ref_no) " +
                    "VALUES((select max(ID) from syn_customer), @dateOfMade, @startDate, @endDate, @location, @refNum);" +

                    "INSERT INTO syn_boat_description (boat_ID, quantity, quote_ID) " +
                    "VALUES((select boat_ID from syn_boat where boat_type = @boatType), @boatQuantity, (SELECT max(ID) from syn_quote));" +

                    "INSERT INTO syn_item_description (item_ID, quantity, quote_ID) " +
                    "VALUES((select item_ID from syn_item where item_type = @itemType), @itemQuantity, (SELECT max(ID) from syn_quote));" +
                    "COMMIT;";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //customer details
                cmd.Parameters.AddWithValue("@firstname", quote.Customer.FirstName);
                cmd.Parameters.AddWithValue("@lastname", quote.Customer.LastName);
                cmd.Parameters.AddWithValue("@address", quote.Customer.Address);
                cmd.Parameters.AddWithValue("@zipcode", quote.Customer.Zipcode);
                cmd.Parameters.AddWithValue("@city", quote.Customer.City);
                cmd.Parameters.AddWithValue("@phone", quote.Customer.Phone);
                cmd.Parameters.AddWithValue("@email", quote.Customer.Email);

                //quote details
                cmd.Parameters.AddWithValue("@dateOfMade", quote.DateTimeOfMade.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@startDate", quote.StartDateTime.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@endDate", quote.EndDateTime.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@location", quote.Location);
                cmd.Parameters.AddWithValue("@refNum", quote.RefNumber);

                //boat description
                cmd.Parameters.AddWithValue("@boatType", quote.Boat.BoatType.ToString());
                cmd.Parameters.AddWithValue("@boatQuantity", quote.Boat.Quantity);

                //boat description
                cmd.Parameters.AddWithValue("@itemType", quote.Item.ItemType.ToString());
                cmd.Parameters.AddWithValue("@itemQuantity", quote.Item.Quantity);

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
        public IEnumerable<Quote> GetAllQuotes()
        {
            try
            {
                List<Quote> allQuotes = new List<Quote>();

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //Query to execute
                string query = "SELECT syn_quote.ID as Quote_ID, `first_name`, `last_name`, `address`, `zipcode`, `city`, `phone`, `email`, " +
                    "`date_of_made`, `start_date`, `end_date`, `location`, ref_no as Quote_refNumber, " +
                    "b.boat_type, b.boat_capacity, b.boat_cost, b.boat_deposit, b_d.quantity as boat_quantity, " +
                    "i.item_type, i.item_cost, i.item_deposit, i_d.quantity as item_quantity FROM `syn_customer` " +
                    "inner join syn_quote on syn_customer.ID = syn_quote.customer_ID INNER JOIN syn_boat_description as b_d on b_d.quote_ID = syn_quote.ID " +
                    "INNER JOIN syn_item_description as i_d on i_d.quote_ID = syn_quote.ID INNER JOIN syn_boat as b on b_d.boat_ID = b.boat_ID " +
                    "INNER JOIN syn_item as i on i.item_ID = i_d.item_ID;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Quote quote = new Quote();

                    //customer details
                    quote.Customer.FirstName = dr["first_name"].ToString();
                    quote.Customer.LastName = dr["last_name"].ToString();
                    quote.Customer.Address = dr["address"].ToString();
                    quote.Customer.Zipcode = dr["zipcode"].ToString();
                    quote.Customer.City = dr["city"].ToString();
                    quote.Customer.Phone = Convert.ToInt32(dr["phone"]);
                    quote.Customer.Email = dr["email"].ToString();

                    //quote details
                    quote.RefNumber = dr["Quote_refNumber"].ToString();
                    quote.DateTimeOfMade = Convert.ToDateTime(dr["date_of_made"]);
                    quote.StartDateTime = Convert.ToDateTime(dr["start_date"]);
                    quote.EndDateTime = Convert.ToDateTime(dr["end_date"]);
                    quote.Location = dr["location"].ToString();

                    //boat details
                    string boatType = dr["boat_type"].ToString();
                    string capacity = dr["boat_capacity"].ToString();
                    double boatCost = Convert.ToDouble(dr["boat_cost"]);
                    double boatDeposit = Convert.ToDouble(dr["boat_deposit"]);
                    int boatQuantity = Convert.ToInt32(dr["boat_quantity"]);

                    //item details
                    string itemType = dr["item_type"].ToString();
                    double itemCost = Convert.ToDouble(dr["item_cost"]);
                    double itemDeposit = Convert.ToDouble(dr["item_deposit"]);
                    int itemQuantity = Convert.ToInt32(dr["item_quantity"]);

                    string remark = null;

                    quote.Boat = new Boat((BOATTYPE)Enum.Parse(typeof(BOATTYPE), boatType), (CAPACITY)Enum.Parse(typeof(CAPACITY), capacity), boatCost, boatDeposit, boatQuantity, remark);
                    quote.Item = new Item((ITEMTYPE)Enum.Parse(typeof(ITEMTYPE), itemType), itemCost, itemDeposit, itemQuantity, remark);

                    allQuotes.Add(quote);
                }

                con.Close();

                return allQuotes;
            }
            
            catch (Exception)
            {
                throw;
                //return inventory;
            }
        }
    }
}
