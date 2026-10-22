using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cars55.Katalog;
using Cars55.Models;
using Cars55.Data;
using Cars55.Workers;
using Cars55.Klients;
using Cars55.Sales;

namespace Cars55.Menu2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnKatalog_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            form2.FormClosed += (s, args) => this.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            form3.FormClosed += (s, args) => this.Show();
        }

        private void btnKlient_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
            form4.FormClosed += (s, args) => this.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
            form9.FormClosed += (s, args) => this.Show();
        }
    }
}
