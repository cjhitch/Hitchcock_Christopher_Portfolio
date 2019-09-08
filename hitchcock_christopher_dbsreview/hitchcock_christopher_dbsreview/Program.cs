using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace hitchcock_christopher_dbsreview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Start\n");
            Program instance = new Program();
            Utility.StartConnection();

            // new date for the Orlando addition
            DateTime now = new DateTime();
            now = DateTime.Now;
            // insert statement to add orlando
            string addOrlando = "INSERT INTO weather(city, temp, pressure, humidity, createdDate) VALUES ('Orlando', 75, 29.97, 84, @now)";
            // start cmd for Orlando
            MySqlCommand orCmd = new MySqlCommand(addOrlando, Utility.Conn);
            // data binding for the date
            orCmd.Parameters.AddWithValue("@now", now);
            // run
            MySqlDataReader rdrOr = orCmd.ExecuteReader();
            // close reader
            rdrOr.Close();
            
            // prompt and validate user input isn't left blank for a city'
            string userCity = Validation.GetString("Enter a city you would like to check the weather for. ");
            // select statement for city
            string stm ="SELECT temp, pressure, humidity, createdDate FROM weather WHERE city = @city ORDER BY createdDate DESC";
            // new cmd
            MySqlCommand cmd = new MySqlCommand(stm, Utility.Conn);
            // data binding for user entered city
            cmd.Parameters.AddWithValue("@city", userCity);
            // run
            MySqlDataReader rdr = cmd.ExecuteReader();
            // checks to see if the table has a city that the user entered
            if (rdr.Read())
            {
                // no need for while loop. Only trying to return the first row anyway
                Console.WriteLine($"The temperature in {instance.CapitalizeFirstChar(userCity)} is : {rdr["temp"]}");
                Console.WriteLine($"The pressure in {instance.CapitalizeFirstChar(userCity)} is : {rdr["pressure"]}");
                Console.WriteLine($"The humidity in {instance.CapitalizeFirstChar(userCity)} is : {rdr["humidity"]}");
            }
            else
            {
                // if the user didn't enter a city that is in the table
                Console.WriteLine("No Data Available for the selected city.");
            }

        }
        string CapitalizeFirstChar(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }
    }
}