using Cars55.Data;
using Cars55.Katalog;
using Cars55.Models;
using Cars55.Workers;
using Microsoft.EntityFrameworkCore;
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

namespace Cars55.Workers
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            LoadPersonas();
        }

        private void LoadPersonas()
        {
            using var db = new AppDbContext();
            dataGridView1.DataSource = db.Personas.AsNoTracking().ToList();
        }

        private void Addbt_Click(object sender, EventArgs e)
        {
            using (var form = new Form6())
            {
                form.ShowDialog(this);

                LoadPersonas();
            }
        }
        private Persona GetSelectPers()
        {
            return dataGridView1.CurrentRow?.DataBoundItem as Persona;
        }

        private void EditBt_Click(object sender, EventArgs e)
        {
            Persona pers = GetSelectPers();

            using (var form = new Form6(pers))
            {
                form.ShowDialog(this);
            }

            LoadPersonas();
        }

        private void DelBt_Click(object sender, EventArgs e)
        {
            Persona pers = GetSelectPers();
            if (pers == null)
            {
                MessageBox.Show("Сначала выберите персонал.");
                return;
            }
            DialogResult result = MessageBox.Show($"Удалить {pers.Имя} {pers.Фамилия}?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            using (var db = new AppDbContext())
            {
                Persona persToDelete = db.Personas.Find(pers.Id);
                if (persToDelete != null)
                {
                    db.Personas.Remove(persToDelete);
                    db.SaveChanges();
                }
            }
            LoadPersonas();
        }
    }
}
