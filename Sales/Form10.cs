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

namespace Cars55.Sales
{
    public partial class Form10 : Form
    {
        private int _SaleId = 0; // 0 — добавление новой продажи, иначе — редактирование существующей

        public Form10()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        // конструктор для редактирования: заполняет поля данными выбранной продажи
        public Form10(Sale sale) : this()
        {
            _SaleId = sale.Id;

            LoadComboBoxes(sale.CarId); // перезагружаем список, чтобы в нём был и проданный автомобиль этой записи

            cmbKlient.SelectedValue = sale.KlientId;
            cmbCar.SelectedValue = sale.CarId;
            cmbSotrudnik.SelectedValue = sale.SotrudnikId == 0 ? 0 : sale.SotrudnikId;
            dtpData.Value = sale.Дата;
            numSumma.Value = sale.Сумма;

            Text = "Изменение продажи";
            btnAdd.Text = "Сохранить";
        }

        // заполняет выпадающие списки клиентами, автомобилями и сотрудниками из общей базы
        private void LoadComboBoxes(int editCarId = 0)
        {
            using (var db = new AppDbContext())
            {
                cmbKlient.DataSource = db.Klients.ToList();
                cmbKlient.DisplayMember = "Имя";
                cmbKlient.ValueMember = "Id";

                // при редактировании показываем и тот автомобиль, который записан в этой продаже
                cmbCar.DataSource = db.Cars.Where(c => c.Статус != "Продан" || c.Id == editCarId).ToList();
                cmbCar.DisplayMember = "Модель";
                cmbCar.ValueMember = "Id";

                // сотрудники из раздела персонал, первая строчка — заглушка, чтобы продавца выбирали явно
                var personas = db.Personas.ToList();
                personas.Insert(0, new Persona { Id = 0, Имя = "-- выберите сотрудника --" });

                cmbSotrudnik.DataSource = personas;
                cmbSotrudnik.DisplayMember = "Имя";
                cmbSotrudnik.ValueMember = "Id";
            }
        }

        // когда выбрали автомобиль — подставляем его цену в сумму
        private void cmbCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCar.SelectedItem is Car car)
            {
                numSumma.Value = car.Цена;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbKlient.SelectedValue == null)
            {
                MessageBox.Show("Сначала добавьте клиента.");
                return;
            }

            if (cmbCar.SelectedValue == null)
            {
                MessageBox.Show("Сначала добавьте автомобиль.");
                return;
            }

            if (numSumma.Value <= 0)
            {
                MessageBox.Show("Сумма должна быть выше 0");
                return;
            }

            if ((int)cmbSotrudnik.SelectedValue == 0)
            {
                MessageBox.Show("Укажите сотрудника, который продал автомобиль.");
                return;
            }

            var sale = new Sale
            {
                KlientId = (int)cmbKlient.SelectedValue,
                CarId = (int)cmbCar.SelectedValue,
                SotrudnikId = (int)cmbSotrudnik.SelectedValue,
                Дата = dtpData.Value.Date,
                Сумма = numSumma.Value
            };

            using (var db = new AppDbContext())
            {
                if (_SaleId == 0) // добавление — как было раньше
                {
                    db.Sales.Add(sale);

                    // помечаем автомобиль как проданный
                    Car car = db.Cars.Find(sale.CarId);
                    if (car != null)
                    {
                        car.Статус = "Продан";
                    }
                }
                else // редактирование — обновляем существующую запись по Id
                {
                    Sale saleToUpdate = db.Sales.Find(_SaleId);
                    if (saleToUpdate != null)
                    {
                        // если автомобиль заменили — старый возвращаем в каталог, новый помечаем как проданный
                        if (saleToUpdate.CarId != sale.CarId)
                        {
                            Car oldCar = db.Cars.Find(saleToUpdate.CarId);
                            if (oldCar != null)
                            {
                                oldCar.Статус = "В наличии";
                            }

                            Car newCar = db.Cars.Find(sale.CarId);
                            if (newCar != null)
                            {
                                newCar.Статус = "Продан";
                            }
                        }

                        saleToUpdate.KlientId = sale.KlientId;
                        saleToUpdate.CarId = sale.CarId;
                        saleToUpdate.SotrudnikId = sale.SotrudnikId;
                        saleToUpdate.Дата = sale.Дата;
                        saleToUpdate.Сумма = sale.Сумма;
                    }
                }

                db.SaveChanges();
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
