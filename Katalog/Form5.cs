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

namespace Cars55.Katalog
{
    public partial class Form5 : Form
    {
        private int _carId = 0;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(Car car) : this()
        {
            _carId = car.Id;
            txtBrand.Text = car.Марка;
            txtModel.Text = car.Модель;
            numPrice.Value = car.Цена;
            txtColor.Text = car.Цвет;
            numMileage.Value = car.Пробег;
            numYear.Value = car.Год;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                MessageBox.Show("Введите марку автомобиля");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtModel.Text))
            {
                MessageBox.Show("Введите модель автомобиля.");
                return;
            }

            if (numPrice.Value <= 0)
            {
                MessageBox.Show("Цена должна быть выше 0");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Введите цвет");
                return;
            }

            var car = new Car
            {
                Id = _carId,
                Марка = txtBrand.Text,
                Модель = txtModel.Text,
                Цена = numPrice.Value,
                Год  = (int)numYear.Value,
                Цвет = txtColor.Text,
                Пробег = numMileage.Value,
                Статус = "В наличии"
            };

            using (var db = new AppDbContext())
            {
                if (_carId == 0)
                {
                    db.Cars.Add(car);
                }
                else
                {
                    db.Cars.Update(car);
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
