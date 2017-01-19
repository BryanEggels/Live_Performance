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
    public class PizzaSQLcontext : IPizzacontext
    {
        public Pizza AddPizza(Pizza pizza)
        {
            string insertpizza = "INSERT INTO Pizza (Naam,Vorm,Formaat) VALUES (@naam,@vorm,@formaat) " + "SELECT SCOPE_IDENTITY()";
            string insertpizza_product = "INSERT INTO PizzaProduct (ProductID,PizzaID,Aantal) VALUES (@product,@pizza,@aantal)";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmdpizza = new SqlCommand(insertpizza, con);
                

                cmdpizza.Parameters.AddWithValue("@naam", pizza.naam);
                cmdpizza.Parameters.AddWithValue("@vorm", pizza.vorm);
                cmdpizza.Parameters.AddWithValue("@formaat", pizza.oppervlakte);

                

                
                
                try
                {
                    int ID = Convert.ToInt32(cmdpizza.ExecuteScalar());
                    pizza.ID = ID;
                    foreach (Ingredient ingredient in pizza.ingredienten)
                    {
                        SqlCommand cmdpizza_product = new SqlCommand(insertpizza_product, con);
                        cmdpizza_product.Parameters.AddWithValue("@pizza", ID);
                        cmdpizza_product.Parameters.AddWithValue("@aantal", 1);
                        cmdpizza_product.Parameters.AddWithValue("@product", ingredient.ID);
                        cmdpizza_product.ExecuteNonQuery();
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }

                return pizza;
            }
        }

        public List<Pizza> standaardpizzas()
        {
            List<Pizza> pizzas = new List<Pizza>();
            string select_query = "SELECT * FROM Pizza WHERE Naam IS NOT NULL";

            using (SqlConnection con = Database.Connection)
            {
                SqlCommand select_cmd = new SqlCommand(select_query, con);

                try
                {
                    SqlDataReader reader = select_cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pizzas.Add(new Pizza
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            naam = reader["Naam"].ToString(),
                            vorm = reader["Vorm"].ToString(),
                            oppervlakte = Convert.ToInt32(reader["Formaat"])
                        });
                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                return pizzas;
            }
        }
    }
}
