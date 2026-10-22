using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cars55.Data;
using Cars55.Katalog;
using Cars55.Models;

namespace Cars55
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            LoadCars();

        }
        private void LoadCars() //  загружает автомобили из базы и обновляет строки на экране.
        {
            using (var db = new AppDbContext())
            {
                var cars = db.Cars.ToList();

                dgvCars.DataSource = cars;

                if (dgvCars.Columns["priceDataGridViewTextBoxColumn"] != null)
                    dgvCars.Columns["priceDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0"; // цена в разрядах по тысячи чтобы отображение

                if (dgvCars.Columns["mileageDataGridViewTextBoxColumn"] != null)
                    dgvCars.Columns["mileageDataGridViewTextBoxColumn"].DefaultCellStyle.Format = "N0"; // тоже самое только для пробега

                lblStatus.Text = $"Автомобили: {cars.Count}";
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (var form = new Form5()) // создаем форму 5
            {
                form.ShowDialog(this); // открытие формы 5
            }

            LoadCars();
        }
        private Car GetSelectedCar() // возвращает автомобиль по текущей строке таблицы
        {
            return dgvCars.CurrentRow?.DataBoundItem as Car;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
         Car car = GetSelectedCar(); // получаем выбранную машину

            using (var form = new Form5(car))
            {
                form.ShowDialog(this);
            }

            LoadCars() ;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Car car = GetSelectedCar(); // проверка на выбранную строку
            if (car == null)
            {
                MessageBox.Show("Сначала выберите автомобиль.");
                return;
            }
            DialogResult result = MessageBox.Show($"Удалить {car.Марка} {car.Модель}?","Подтверждение", MessageBoxButtons.YesNo,MessageBoxIcon.Question); // подтверждение перед удалением

            if (result != DialogResult.Yes) // если нет
                return;

            using (var db = new AppDbContext()) // создает контекст для работы с текущей базой
            {
                Car carToDelete = db.Cars.Find(car.Id); // ищем автомобиль в текущей базе по его Id
                if (carToDelete != null) // если это не равно null тогда вот if не выполнится
                {
                    db.Cars.Remove(carToDelete);
                    db.SaveChanges();
                }
            }
            LoadCars();
        }
    }
}
