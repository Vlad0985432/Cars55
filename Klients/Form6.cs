using Cars55.Data;
using Cars55.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cars55.Workers
{
    public partial class Form6 : Form
    {
        private int _PersId = 0;
        public Form6()
        {
            InitializeComponent();
        }
        public Form6(Persona pers) : this()
        {
            _PersId = pers.Id;
            txtName.Text = pers.Имя;
            txtFam.Text = pers.Фамилия;
            txtStatus.Text = pers.Должность;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Введите имя");
                return;

            }
            if (string.IsNullOrWhiteSpace(txtFam.Text))
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtStatus.Text))
            {
                MessageBox.Show("Введитее должность");
                return;
            }
            var pers = new Persona
            {
                Id = _PersId,
                Имя = txtName.Text,
               Фамилия = txtFam.Text,
               Должность = txtStatus.Text
            };
            using (var db = new AppDbContext())
            {
                if (_PersId == 0)
                {
                    db.Personas.Add(pers);
                }
                else
                {
                    db.Personas.Update(pers);
                }
             db.SaveChanges();
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
