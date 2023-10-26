using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorAuto.Interfaces
{
    public interface IOption
    {
        TypeOfOption Type { get; set; }
        string Manufacturer { get; set; }
        int Price { get; set; }
    }
}
