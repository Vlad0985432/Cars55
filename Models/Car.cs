using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars55.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Марка { get; set; } = "";
        public string Модель { get; set; } = "";
        public int Год { get; set; }
        public decimal Цена { get; set; }
        public string Цвет { get; set; } = "";
        public decimal Пробег { get; set; }
        public string Статус { get; set; } = "";
    }

}
