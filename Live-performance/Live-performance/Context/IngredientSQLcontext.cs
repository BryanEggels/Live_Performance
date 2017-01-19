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
    public class IngredientSQLcontext : IIngredientcontext
    {
        public List<Ingredient> GetAll()
        {
            List<Ingredient> ingredienten = new List<Ingredient>();
            string select_query = "SELECT * FROM Product WHERE Ingredient = 1";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ingredienten.Add(new Ingredient
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Naam = reader["Naam"].ToString(),
                            Inkoopprijs = Convert.ToInt32(reader["Inkoopprijs"]),
                            Verkoopprijs = Convert.ToInt32(reader["Verkoopprijs"]),
                            Halal = Convert.ToBoolean(reader["Halal"]),
                            Veganistisch = Convert.ToBoolean(reader["Veganistisch"]),
                            BTW = Convert.ToInt32(reader["BTW"])                            
                        });
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return ingredienten;
            }
        }
    }
}
