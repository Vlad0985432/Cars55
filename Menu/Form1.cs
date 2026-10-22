using Cars55.Data;
using Cars55.Models;
using Cars55.Menu2;

namespace Cars55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using var db = new AppDbContext();

            bool ok = false;                      // по умолчанию считаем, что не нашли
            foreach (User u in db.Users.ToList()) // идём по всем строкам таблицы
            {
                if (u.Login == txtLogin.Text && u.Password == txtPassword.Text)
                {
                    ok = true;                    // нашли совпадение
                    break;                        
                }
            }

            if (ok)
            {
                MessageBox.Show("Добро пожаловать, " + txtLogin.Text + "!");

                Form7 form7 = new Form7();

                form7.FormClosed += (s, args) => this.Close();

                form7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();    // Trim убирает пробелы по краям
            string password = txtPassword.Text;

            // 1. Проверяем, что поля не пустые
            if (login == "" || password == "")
            {
                MessageBox.Show("Введите логин и пароль!");
                return; 
            }

            using (var db = new AppDbContext())
            {
                // 2. Проверяем, не занят ли уже такой логин
                bool loginTaken = db.Users.Any(u => u.Login == login);
                if (loginTaken)
                {
                    MessageBox.Show("Такой логин уже занят, придумайте другой!");
                    return;
                }

                // 3. Создаём нового пользователя и сохраняем в базу
                User newUser = new User
                {
                    Login = login,
                    Password = password
                };

                db.Users.Add(newUser);  
                db.SaveChanges();       

                MessageBox.Show("Регистрация прошла успешно! Теперь войдите.");
            }
        }
    }

}