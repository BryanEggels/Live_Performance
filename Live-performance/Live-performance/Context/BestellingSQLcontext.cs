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
    public class BestellingSQLcontext : IBestellingcontext
    {
        public bool Add(Bestelling bestelling)
        {
            string insertbestelling = "INSERT INTO Bestelling (KlantID) VALUES (@KlantID) " + "SELECT SCOPE_IDENTITY()";
            string insertproduct = "INSERT INTO Productbestelling (ProductID,BestellingID,Aantal) VALUES (@productid,@bestelid,1)";
            string insertpizza = "INSERT INTO Pizzabestelling (BestellingID,PizzaID,Aantal) VALUES (@bestelid,@pizzaid,1)";
            bestelling.newklant();
            using (SqlConnection con = Database.Connection)
            {
                SqlCommand cmd = new SqlCommand(insertbestelling, con);

                cmd.Parameters.AddWithValue("@KlantID", bestelling.klant.ID);

                try
                {
                    int bestelID = Convert.ToInt32(cmd.ExecuteScalar());
                    foreach (Product product in bestelling.producten)
                    {
                        SqlCommand cmdinsertproduct = new SqlCommand(insertproduct, con);
                        cmdinsertproduct.Parameters.AddWithValue("@bestelid", bestelID);
                        cmdinsertproduct.Parameters.AddWithValue("@productid", product.ID);
                        cmdinsertproduct.ExecuteNonQuery();
                    }
                    foreach (Pizza pizza in bestelling.pizzas)
                    {
                        SqlCommand cmdinsertpizza = new SqlCommand(insertpizza, con);
                        cmdinsertpizza.Parameters.AddWithValue("@bestelid", bestelID);
                        cmdinsertpizza.Parameters.AddWithValue("@pizzaid", pizza.ID);
                        cmdinsertpizza.ExecuteNonQuery();
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

        public List<Bestelling> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Bestelling> GetAll(Klant klant)
        {
            throw new NotImplementedException();
        }
    }
}
