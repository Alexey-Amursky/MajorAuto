using MajorAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorAuto
{
    public class Option : IOption
    {
        public TypeOfOption Type { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }

        public Option() { }

        public Option(TypeOfOption type, string manufacturer, int price)
        {
            Type = type;
            Manufacturer = manufacturer;
            Price = price;
        }
    }
}
