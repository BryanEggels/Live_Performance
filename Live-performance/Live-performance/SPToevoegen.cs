using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_performance.Repositories;
using Live_performance.Models;
using Live_performance.Context.Interfaces;
using Live_performance.Context;



namespace Live_performance
{
    public partial class SPToevoegen : Form
    {
        string vorm = "rond";
        public SPToevoegen()
        {
            InitializeComponent();
        }

        private void btn_toevoegen_Click(object sender, EventArgs e)
        {


            Pizza pizza = new Pizza
            {
                naam = tb_naam.Text,
                oppervlakte = (int)num_oppervlakte.Value,
                vorm = this.vorm
            };
            
            foreach (Ingredient ingredient in lb_ingredienten.SelectedItems)
            {
                pizza.ingredienten.Add(ingredient);
                
            }
            pizza.ingredienten.Add((Ingredient)lb_bodem.SelectedItem);
            if(new Pizzarepository(new PizzaSQLcontext()).AddPizza(pizza).ID > 1)
            {
                MessageBox.Show("Toevoegen gelukt", "succes!");
            }
            
        }

        private void SPToevoegen_Load(object sender, EventArgs e) //vult alle listboxes met waardes
        {
            lb_ingredienten.SelectionMode = SelectionMode.MultiExtended;
            lb_ingredienten.DataSource = new Ingredientrepository(new IngredientSQLcontext()).GetAll();
            lb_bodem.DataSource = new Productrepository(new ProductSQLcontext()).AlleBodems();
        }

        private void rb_rond_Click(object sender, EventArgs e)
        {
            vorm = "rond";
        }

        private void rb_vierkant_CheckedChanged(object sender, EventArgs e)
        {
            vorm = "vierkant";
        }

        private void rb_driehoek_CheckedChanged(object sender, EventArgs e)
        {
            vorm = "driehoek";
        }
    }
}
