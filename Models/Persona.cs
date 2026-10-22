using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars55.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Имя { get; set; } = "";
        public string Фамилия { get; set; } = "";
        public string Должность { get; set; } = "";
        public decimal Продажи {  get; set; }
    }

}
