using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Live_performance.Context.Interfaces;
using Live_performance.Models;
using System.Data.SqlClient;

namespace Live_performance.Context
{
    public class KlantSQLcontext : IKlantcontext
    {
        public Klant add(Klant klant)
        {
            string insertklant = "INSERT INTO Klant (Naam,Adres) VALUES (@naam,@adres) " + "SELECT SCOPE_IDENTITY()";
           

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(insertklant, con);


                cmd.Parameters.AddWithValue("@naam", klant.Naam);
                cmd.Parameters.AddWithValue("@adres", klant.Adres);

                try
                {
                    klant.ID = Convert.ToInt32(cmd.ExecuteScalar());
                    
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return klant;
                }
                return klant;
            }
        }
    }
}
