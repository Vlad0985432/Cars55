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
using Microsoft.EntityFrameworkCore;

namespace Cars55.Sales
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            LoadSales();
        }
        private void LoadSales() // загружает продажи со связанными клиентами, автомобилями и сотрудниками.
        {
            using (var db = new AppDbContext())
            {
                var sales = db.Sales
                    .Include(s => s.Klient)     // подтягивает клиента по внешнему ключу
                    .Include(s => s.Car)        // подтягивает автомобиль по внешнему ключу
                    .Include(s => s.Sotrudnik)  // подтягивает сотрудника по внешнему ключу
                    .AsNoTracking()
                    .ToList();

                // DataGridView не читает вложенные объекты (Klient.Имя, Car.Марка),
                // поэтому раскладываем каждую продажу в простую строку SaleRow
                var rows = sales.Select(sale => new SaleRow
                {
                    Id = sale.Id,
                    Клиент = sale.Klient?.Имя ?? "",
                    Автомобиль = $"{sale.Car?.Марка} {sale.Car?.Модель}",
                    Сотрудник = sale.Sotrudnik == null ? "" : $"{sale.Sotrudnik?.Имя} {sale.Sotrudnik?.Фамилия}",
                    Дата = sale.Дата,
                    Сумма = sale.Сумма
                }).ToList();

                dgvSales.DataSource = rows;

                lblStatus.Text = $"Продажи: {rows.Count}";
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (var form = new Form10()) // создаем форму 10
            {
                form.ShowDialog(this); // открытие формы 10
            }

            LoadSales();
        }

        private SaleRow GetSelectedSale() // возвращает продажу по текущей строке таблицы
        {
            return dgvSales.CurrentRow?.DataBoundItem as SaleRow;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            SaleRow row = GetSelectedSale(); // проверка на выбранную строку
            if (row == null)
            {
                MessageBox.Show("Сначала выберите продажу.");
                return;
            }

            using (var db = new AppDbContext())
            {
                Sale sale = db.Sales.Find(row.Id); // берём настоящую запись из базы по Id строки
                if (sale != null)
                {
                    using (var form = new Form10(sale)) // открываем форму продажи в режиме редактирования
                    {
                        form.ShowDialog(this);
                    }
                }
            }

            LoadSales();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            SaleRow sale = GetSelectedSale(); // проверка на выбранную строку
            if (sale == null)
            {
                MessageBox.Show("Сначала выберите продажу.");
                return;
            }
            DialogResult result = MessageBox.Show($"Удалить продажу клиента {sale.Клиент} (авто: {sale.Автомобиль})?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // подтверждение перед удалением

            if (result != DialogResult.Yes) // если нет
                return;

            using (var db = new AppDbContext())
            {
                Sale saleToDelete = db.Sales.Find(sale.Id); // ищем продажу в текущей базе по её Id
                if (saleToDelete != null) // если это не равно null тогда вот if не выполнится
                {
                    // возвращаем автомобиль в каталог, чтобы его снова можно было продать
                    Car car = db.Cars.Find(saleToDelete.CarId);
                    if (car != null)
                    {
                        car.Статус = "В наличии";
                    }

                    db.Sales.Remove(saleToDelete);
                    db.SaveChanges();
                }
            }
            LoadSales();
        }
    }

    // строка таблицы продаж: все поля простые, без вложенных объектов
    public class SaleRow
    {
        public int Id { get; set; }
        public string Клиент { get; set; } = "";
        public string Автомобиль { get; set; } = "";
        public string Сотрудник { get; set; } = "";
        public DateTime Дата { get; set; }
        public decimal Сумма { get; set; }
    }
}
