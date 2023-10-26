using MajorAuto.Interfaces;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorAuto
{
    public class CarShop : ICarShop
    {
        private ICollection<ICar> cars;
        private Dictionary<IOption,double> _options;

        public CarShop()
        {
            cars = new List<ICar>();
            _options = new Dictionary<IOption, double>();
        }

        public void AddCar(ICar car)
        {
            cars.Add(car);
        }

        public void RemoveCar(int id)
        {
            ICar carToRemove = cars.FirstOrDefault(car => car.ID == id);
            if (carToRemove != null)
            {
                cars.Remove(carToRemove);
            }
        }

        public void AddOptions(int id, IOption option, double price)
        {
            ICar car = cars.FirstOrDefault(c => c.ID == id);
            if (car != null)
            {
                _options.Add(option, price);
            }
        }

        public Dictionary<IOption, double> Get_options()
        {
            return _options;
        }

        public void RemoveOptions(TypeOfOption option, Dictionary<IOption, double> _options)
        {
            IOption optionToRemove = _options.Keys.FirstOrDefault(o => o.Type == option);
            if (optionToRemove != null)
            {
                _options.Remove(optionToRemove);
            }
        }
        public double CalculateTotalPrice()
        {
            return _options.Sum(o => o.Value);
        }
    }
}
