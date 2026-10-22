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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            LoadKlients();
        }
        private void LoadKlients() // загружает клиентов из базы и обновляет строки на экране.
        {
            using (var db = new AppDbContext())
            {
                var klients = db.Klients.ToList();

                dgvKlients.DataSource = klients;

                lblStatus.Text = $"Клиенты: {klients.Count}";
            }
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (var form = new Form8()) // создаем форму 8
            {
                form.ShowDialog(this); // открытие формы 8
            }

            LoadKlients();
        }
        private Klient GetSelectedKlient() // возвращает клиента по текущей строке таблицы
        {
            return dgvKlients.CurrentRow?.DataBoundItem as Klient;
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Klient klient = GetSelectedKlient(); // получаем выбранного клиента
            if (klient == null)
            {
                MessageBox.Show("Сначала выберите клиента.");
                return;
            }

            using (var form = new Form8(klient))
            {
                form.ShowDialog(this);
            }

            LoadKlients();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Klient klient = GetSelectedKlient(); // проверка на выбранную строку
            if (klient == null)
            {
                MessageBox.Show("Сначала выберите клиента.");
                return;
            }
            DialogResult result = MessageBox.Show($"Удалить клиента {klient.Имя} (тел. {klient.Номер})?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question); // подтверждение перед удалением

            if (result != DialogResult.Yes) // если нет
                return;

            using (var db = new AppDbContext()) // создает контекст для работы с текущей базой
            {
                Klient klientToDelete = db.Klients.Find(klient.Id); // ищем клиента в текущей базе по его Id
                if (klientToDelete != null) // если это не равно null тогда вот if не выполнится
                {
                    db.Klients.Remove(klientToDelete);
                    db.SaveChanges();
                }
            }
            LoadKlients();
        }
    }
}
