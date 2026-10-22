using System;

namespace Cars55.Models
{
    public class Sale
    {
        public int Id { get; set; }

        // внешний ключ на клиента (связь один-ко-многим: у одного клиента может быть несколько продаж)
        public int KlientId { get; set; }
        public Klient? Klient { get; set; }

        // внешний ключ на автомобиль (у одного автомобиля может быть несколько записей о продаже)
        public int CarId { get; set; }
        public Car? Car { get; set; }

        // внешний ключ на сотрудника (кто из персонала продал автомобиль)
        public int SotrudnikId { get; set; }
        public Persona? Sotrudnik { get; set; }

        public DateTime Дата { get; set; }
        public decimal Сумма { get; set; }
    }
}
