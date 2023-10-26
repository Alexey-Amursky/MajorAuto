using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorAuto.Interfaces
{
    public interface ICarShop
    {
        void AddCar(ICar car);
        void RemoveCar(int id);
        void AddOptions(int id, IOption option);
        void RemoveOptions(TypeOfOption option);
        double CalculateTotalPrice();
    }
}
