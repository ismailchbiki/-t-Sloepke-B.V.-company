using MySql.Data.MySqlClient;
using SynthesisAssignment.MyClasses.Classes;
using SynthesisAssignment.Services.DALInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthesisAssignment.Services
{
    public class DALQuotePayment : IProcessQuote
    {
        //QUOTE PROCESSING
        public bool SettleDeposit(Quote quote)
        {
            bool status = false;

            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "UPDATE `syn_quote` SET deposit_status=@depositStatus where ref_no=@refNum;";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //quote details
                cmd.Parameters.AddWithValue("@refNum", quote.RefNumber);
                cmd.Parameters.AddWithValue("@depositStatus", "Done");

                //Open the connection
                con.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Close the connection
                con.Close();

                status = true;
            }
            catch (Exception)
            {
                throw;
                //status = false;
            }
            return status;
        }
        public bool SettlePayment(Quote quote)
        {
            bool status = false;

            try
            {
                //connection string
                MySqlConnection con = new MySqlConnection(ConnectionString.MyConnection);

                string sqlQuery = "UPDATE `syn_quote` SET payment_status=@paymentStatus where ref_no=@refNum;";

                MySqlCommand cmd = new MySqlCommand(sqlQuery, con);

                //quote details
                cmd.Parameters.AddWithValue("@refNum", quote.RefNumber);
                cmd.Parameters.AddWithValue("@paymentStatus", "Done");

                //Open the connection
                con.Open();

                //Execute the command
                cmd.ExecuteNonQuery();

                //Close the connection
                con.Close();

                status = true;
            }
            catch (Exception)
            {
                throw;
                //status = false;
            }
            return status;
        }
    }
}
