using Cars55.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Cars55
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            SQLitePCL.Batteries_V2.Init(); // подключение sqlite

            using (var db = new AppDbContext())
            {
                db.Database.EnsureCreated(); // создаёт базу, если её ещё нет
                AddSotrudnikColumnToSales(db); // дополняет старую базу колонкой сотрудника, если её нет
            }

            Application.Run(new Form1());
        }

        private static void AddSotrudnikColumnToSales(AppDbContext db)
        {
            SqliteConnection connection = (SqliteConnection)db.Database.GetDbConnection(); // настоящее подключение к файлу базы
            connection.Open();

            bool hasColumn = false;
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "PRAGMA table_info(Sales)"; // смотрим, какие колонки уже есть в таблице Sales
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.GetString(1) == "SotrudnikId")
                        {
                            hasColumn = true;
                            break;
                        }
                    }
                }
            }

            if (!hasColumn) // колонки нет — база создана старым кодом, добавляем её вручную (данные не теряются)
            {
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "ALTER TABLE Sales ADD COLUMN SotrudnikId INTEGER NOT NULL DEFAULT 0";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
