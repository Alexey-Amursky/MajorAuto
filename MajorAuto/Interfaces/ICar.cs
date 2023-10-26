using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorAuto.Interfaces
{
    public interface ICar
    {
        int ID { get; init; }
        Models Models { get; init; }
        string Name { get; init; }
        int MaxSpeed { get; init; }
        int Weight { get; init; }
        TransmissionType TransmissionType { get; init; }
        TypeOfEngine TypeOfEngine { get; init; }
        int Price { get; set; }
    }
}
