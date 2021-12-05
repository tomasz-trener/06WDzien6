using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01PolaczenieZBaza
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // do komumikacji z baza danych 
            SqlCommand command; // przechowywanie polecen SQL 
            SqlDataReader dataReader; // czytania odpowiedzi z bazy danych 

            string connString = "Data Source=.;Initial Catalog=A_Zawodnicy;User ID=sa;Password=alx";
            connection = new SqlConnection(connString);

            command = new SqlCommand("SELECT * FROM zawodnicyXX", connection);

            try
            {
                connection.Open();
                dataReader = command.ExecuteReader(); // wysłanie polecenia sql do bazy
                                                      // dataReader jest uchwytem do wyniku 


                while (dataReader.Read())
                {
                    string imieNazwisko = (string)dataReader.GetValue(2) + " " +
                            (string)dataReader.GetValue(3);

                    Console.WriteLine(imieNazwisko);
                }
            }
            catch (Exception ex)
            {
              //  throw ex;
              //  Console.WriteLine(ex.Message);
                Console.WriteLine("błąd bazy danych");
            }
            finally
            {
                connection.Close();
            }

            //dataReader.Read(); // czyta kolejny wierszy 
            //string imie = (string)dataReader.GetValue(2);
            //Console.WriteLine(imie);


            //dataReader.Read();
            //imie = (string)dataReader.GetValue(2);
            //Console.WriteLine(imie);


            Console.ReadKey();

        }
    }
}
