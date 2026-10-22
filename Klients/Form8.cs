using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cars55.Data;
using Cars55.Models;

namespace Cars55.Klients
{
    public partial class Form8 : Form
    {
        private int _klientId = 0;
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(Klient klient) : this()
        {
            _klientId = klient.Id;
            txtName.Text = klient.Имя;
            txtNumber.Text = klient.Номер;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите имя клиента");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumber.Text))
            {
                MessageBox.Show("Введите телефон клиента");
                return;
            }

            var klient = new Klient
            {
                Id = _klientId,
                Имя = txtName.Text,
                Номер = txtNumber.Text
            };

            using (var db = new AppDbContext())
            {
                if (_klientId == 0)
                {
                    db.Klients.Add(klient);
                }
                else
                {
                    db.Klients.Update(klient);
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
