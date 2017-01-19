using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Live_performance
{
    public partial class ToevoegenForm : Form
    {
        public ToevoegenForm()
        {
            InitializeComponent();
        }

        private void btn_SP_Click(object sender, EventArgs e)
        {
            SPToevoegen form = new SPToevoegen();
            form.Show();
            this.Hide();
        }
    }
}
