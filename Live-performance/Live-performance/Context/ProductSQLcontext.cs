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
    public class ProductSQLcontext : IProductcontext
    {
        public bool Add(Product product)
        {
            string insert = "INSERT INTO Product (Naam,ID) VALUES (@naam,@id) " + "SELECT SCOPE_IDENTITY()";


            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(insert, con);


                cmd.Parameters.AddWithValue("@naam", product.Naam);
                cmd.Parameters.AddWithValue("@id", product.ID);

                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return true;
                }
                return true;
            }
        }

        public List<Product> AlleBodems()
        {
            List<Product> bodems = new List<Product>();
            string select_query = "SELECT * FROM Product WHERE Naam LIKE '%bodem%'";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bodems.Add(new Ingredient
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Naam = reader["Naam"].ToString(),
                            Inkoopprijs = Convert.ToInt32(reader["Inkoopprijs"]),
                            Verkoopprijs = Convert.ToInt32(reader["Verkoopprijs"]),

                        });
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return bodems;
            }
        }

        public List<Product> Alleproducten()
        {
            List<Product> producten = new List<Product>();
            string select_query = "SELECT * FROM Product WHERE Naam NOT LIKE '%bodem%'";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        producten.Add(new Ingredient
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Naam = reader["Naam"].ToString(),
                            Inkoopprijs = Convert.ToDecimal(reader["Inkoopprijs"]),
                            Verkoopprijs = Convert.ToDecimal(reader["Verkoopprijs"]),
                            drank = Convert.ToBoolean(reader["Drank"]),
                            Halal = Convert.ToBoolean(reader["Halal"]),
                            Veganistisch = Convert.ToBoolean(reader["Veganistisch"]),
                            BTW = Convert.ToInt32(reader["BTW"]),
                            ingredient = Convert.ToBoolean(reader["ingredient"])
                        });
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return producten;
            }
        }

        public bool Edit(Product product,int id)
        {


            string query = "UPDATE Product SET Naam = @naam, Inkoopprijs = @inkoop, Verkoopprijs = @verkoop,Ingredient = @ingredient, Drank = @drank, BTW = @btw, Halal = @halal, Veganistisch = @vega WHERE ID = @id";


            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(query, con);


                cmd.Parameters.AddWithValue("@naam", product.Naam);
                cmd.Parameters.AddWithValue("@inkoop", product.Inkoopprijs);
                cmd.Parameters.AddWithValue("@verkoop", product.Verkoopprijs);
                cmd.Parameters.AddWithValue("@ingredient", product.ingredient);
                cmd.Parameters.AddWithValue("@drank", product.drank);
                cmd.Parameters.AddWithValue("@btw", product.BTW);
                cmd.Parameters.AddWithValue("@halal", product.Halal);
                cmd.Parameters.AddWithValue("@vega", product.Veganistisch);
                cmd.Parameters.AddWithValue("@id", id);
                try
                {
                    if(cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
                return true;
            }
        }
    }
}
