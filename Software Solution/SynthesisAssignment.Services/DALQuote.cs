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
        //add quote
        public bool AddQuote(Quote quote)
        {
            try
            {

                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //customer, quote, boat, and item details
                string sqlQuery = "START TRANSACTION;" +
                    "INSERT INTO syn_quote (date_of_made, start_date, end_date, location, duration, total_price, deposit, ref_no) " +
                    "VALUES(@dateOfMade, @startDate, @endDate, @location, @duration, @total_price, @deposit, @refNum);" +

                    "INSERT INTO syn_customer (quote_ID, first_name, last_name, address, zipcode, city, phone, email) " +
                    "VALUES((SELECT max(ID) from syn_quote), @firstname, @lastname, @address, @zipcode, @city, @phone, @email);" +

                    "INSERT INTO syn_boat_description (boat_ID, quantity, boat_price, quote_ID) " +
                    "VALUES((select boat_ID from syn_boat where boat_type = @boatType), @boatQuantity, @boat_price, (SELECT max(ID) from syn_quote));" +

                    "INSERT INTO syn_item_description (item_ID, quantity, item_price, quote_ID) " +
                    "VALUES((select item_ID from syn_item where item_type = @itemType), @itemQuantity, @item_price, (SELECT max(ID) from syn_quote));" +
                    "COMMIT;";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //quote details
                cmd.Parameters.AddWithValue("@dateOfMade", quote.DateTimeOfMade.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@startDate", quote.StartDateTime.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@endDate", quote.EndDateTime.ToString("yyyy-MM-dd HH-mm"));
                cmd.Parameters.AddWithValue("@location", quote.Location);
                cmd.Parameters.AddWithValue("@duration", quote.Duration);
                cmd.Parameters.AddWithValue("@total_price", quote.TotalPrice);
                cmd.Parameters.AddWithValue("@deposit", quote.Deposit);
                cmd.Parameters.AddWithValue("@refNum", quote.RefNumber);

                //customer details
                cmd.Parameters.AddWithValue("@firstname", quote.Customer.FirstName);
                cmd.Parameters.AddWithValue("@lastname", quote.Customer.LastName);
                cmd.Parameters.AddWithValue("@address", quote.Customer.Address);
                cmd.Parameters.AddWithValue("@zipcode", quote.Customer.Zipcode);
                cmd.Parameters.AddWithValue("@city", quote.Customer.City);
                cmd.Parameters.AddWithValue("@phone", quote.Customer.Phone);
                cmd.Parameters.AddWithValue("@email", quote.Customer.Email);

                //boat description
                cmd.Parameters.AddWithValue("@boatType", quote.Boat.BoatType.ToString());
                cmd.Parameters.AddWithValue("@boatQuantity", quote.Boat.Quantity);
                cmd.Parameters.AddWithValue("@boat_price", quote.Boat.Price);

                //boat description
                cmd.Parameters.AddWithValue("@itemType", quote.Item.ItemType.ToString());
                cmd.Parameters.AddWithValue("@itemQuantity", quote.Item.Quantity);
                cmd.Parameters.AddWithValue("@item_price", quote.Item.Price);

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

        //update quote
        public bool UpdateQuote(Quote quote)
        {
            //connection string
            MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

            string sqlQuery = "START TRANSACTION;" +
                "UPDATE `syn_quote` SET date_of_made=@dateOfMade, start_date=@startDate, end_date=@endDate, duration=@duration, total_price=@total_price, deposit=@deposit, `location`=@location where ref_no=@refNum;" +
                "UPDATE syn_customer SET first_name=@firstname, last_name=@lastname, address=@address, zipcode=@zipcode, city=@city, phone=@phone, email=@email where quote_ID = (select ID from syn_quote where ref_no=@refNum);" +
                "UPDATE syn_boat_description SET boat_ID=(select boat_ID from syn_boat where boat_type=@boatType), quantity=@boatQuantity, boat_price=@boat_price where quote_ID = (select ID from syn_quote where ref_no=@refNum);" +
                "UPDATE syn_item_description SET item_ID=(select item_ID from syn_item where item_type=@itemType), quantity=@itemQuantity, item_price=@item_price where quote_ID = (select ID from syn_quote where ref_no=@refNum);" +
                "COMMIT;";

            MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

            //quote details
            cmd.Parameters.AddWithValue("@dateOfMade", quote.DateTimeOfMade.ToString("yyyy-MM-dd HH-mm"));
            cmd.Parameters.AddWithValue("@startDate", quote.StartDateTime.ToString("yyyy-MM-dd HH-mm"));
            cmd.Parameters.AddWithValue("@endDate", quote.EndDateTime.ToString("yyyy-MM-dd HH-mm"));
            cmd.Parameters.AddWithValue("@location", quote.Location);
            cmd.Parameters.AddWithValue("@duration", quote.Duration);
            cmd.Parameters.AddWithValue("@total_price", quote.TotalPrice);
            cmd.Parameters.AddWithValue("@deposit", quote.Deposit);
            cmd.Parameters.AddWithValue("@refNum", quote.RefNumber);

            //customer details
            cmd.Parameters.AddWithValue("@firstname", quote.Customer.FirstName);
            cmd.Parameters.AddWithValue("@lastname", quote.Customer.LastName);
            cmd.Parameters.AddWithValue("@address", quote.Customer.Address);
            cmd.Parameters.AddWithValue("@zipcode", quote.Customer.Zipcode);
            cmd.Parameters.AddWithValue("@city", quote.Customer.City);
            cmd.Parameters.AddWithValue("@phone", quote.Customer.Phone);
            cmd.Parameters.AddWithValue("@email", quote.Customer.Email);

            //boat description
            cmd.Parameters.AddWithValue("@boatType", quote.Boat.BoatType.ToString());
            cmd.Parameters.AddWithValue("@boatQuantity", quote.Boat.Quantity);
            cmd.Parameters.AddWithValue("@boat_price", quote.Boat.Price);

            //boat description
            cmd.Parameters.AddWithValue("@itemType", quote.Item.ItemType.ToString());
            cmd.Parameters.AddWithValue("@itemQuantity", quote.Item.Quantity);
            cmd.Parameters.AddWithValue("@item_price", quote.Item.Price);


            //Open the connection
            con.Open();

            //Execute the command
            cmd.ExecuteNonQuery();

            //Close the connection
            con.Close();

            return true;
        }

        //delete quote
        public bool DeleteQuote(Quote quote)
        {
            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "DELETE FROM `syn_quote` WHERE ref_no = @ref_no";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                cmd.Parameters.AddWithValue("@ref_no", quote.RefNumber);

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

        // get all the quotes
        public IEnumerable<Quote> GetAllQuotes()
        {
            try
            {
                List<Quote> allQuotes = new List<Quote>();

                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                //Query to execute
                string query = "SELECT `first_name`, `last_name`, `address`, `zipcode`, `city`, `phone`, `email`, " +
                    "`date_of_made`, `start_date`, `end_date`, duration, total_price, deposit, `location`, ref_no as Quote_refNumber, deposit_status, payment_status, " +
                    "b.boat_type, b.boat_capacity, b.boat_cost, b.boat_deposit, b_d.quantity as boat_quantity, b_d.boat_price, " +
                    "i.item_type, i.item_cost, i.item_deposit, i_d.quantity as item_quantity, i_d.item_price FROM `syn_quote` " +
                    "inner join syn_customer on syn_quote.ID = syn_customer.quote_ID INNER JOIN syn_boat_description as b_d on b_d.quote_ID = syn_quote.ID " +
                    "INNER JOIN syn_item_description as i_d on i_d.quote_ID = syn_quote.ID INNER JOIN syn_boat as b on b_d.boat_ID = b.boat_ID " +
                    "INNER JOIN syn_item as i on i.item_ID = i_d.item_ID;";

                MySqlCommand cmd = new MySqlCommand(query, con);

                con.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Quote quote = new Quote();

                    //quote details
                    quote.RefNumber = dr["Quote_refNumber"].ToString();
                    quote.DateTimeOfMade = Convert.ToDateTime(dr["date_of_made"]);
                    quote.StartDateTime = Convert.ToDateTime(dr["start_date"]);
                    quote.EndDateTime = Convert.ToDateTime(dr["end_date"]);
                    quote.Location = dr["location"].ToString();
                    quote.SetDuration(Convert.ToInt32(dr["duration"]));                    
                    quote.GetTotalPrice(Convert.ToDouble(dr["total_price"]));
                    quote.GetDeposit(Convert.ToDouble(dr["deposit"]));
                    quote.SetDepositStatus(dr["deposit_status"].ToString());
                    quote.SetPaymentStatus(dr["payment_status"].ToString());

                    //customer details
                    quote.Customer.FirstName = dr["first_name"].ToString();
                    quote.Customer.LastName = dr["last_name"].ToString();
                    quote.Customer.Address = dr["address"].ToString();
                    quote.Customer.Zipcode = dr["zipcode"].ToString();
                    quote.Customer.City = dr["city"].ToString();
                    quote.Customer.Phone = Convert.ToInt32(dr["phone"]);
                    quote.Customer.Email = dr["email"].ToString();

                    //boat details
                    string boatType = dr["boat_type"].ToString();
                    string capacity = dr["boat_capacity"].ToString();
                    double boatCost = Convert.ToDouble(dr["boat_cost"]);
                    double boatDeposit = Convert.ToDouble(dr["boat_deposit"]);
                    int boatQuantity = Convert.ToInt32(dr["boat_quantity"]);
                    double boatPrice = Convert.ToDouble(dr["boat_price"]);

                    //item details
                    string itemType = dr["item_type"].ToString();
                    double itemCost = Convert.ToDouble(dr["item_cost"]);
                    double itemDeposit = Convert.ToDouble(dr["item_deposit"]);
                    int itemQuantity = Convert.ToInt32(dr["item_quantity"]);
                    double itemPrice = Convert.ToDouble(dr["item_price"]);

                    string remark = null;

                    quote.Boat = new Boat(boatType, boatCost, boatDeposit, boatQuantity, remark, boatPrice);
                    quote.Item = new Item(itemType, itemCost, itemDeposit, itemQuantity, remark, itemPrice);

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
