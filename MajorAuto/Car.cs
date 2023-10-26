using MajorAuto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MajorAuto
{
    public class Car : IDriving
    {
        public int ID { get; init; }
        public Models Models {  get; init; }
        public string Name { get; init; }
        public int MaxSpeed { get; init; }
        public int Weight { get; init; }
        public TransmissionType TransmissionType { get; init; }
        public TypeOfEngine TypeOfEngine { get; init; }

        public IEnumerable<string> _basicEquipment { get; } = new List<string> { "engine", "transmission", "suspension", "steering", "braking system", "lighting", "heating", "air conditioning", "audio system", "airbags" };
        
        public IEnumerable<string> additionalOptions = new List<string>();
        public int Price { get; set; }

        public Car() { }
        public Car(Models models, string name, int maxSpeed, int weight, TransmissionType transmissionType, TypeOfEngine typeOfEngine, int price)
        {
            Models = models;
            Name = name;
            MaxSpeed = maxSpeed;
            Weight = weight;
            TransmissionType = transmissionType;
            TypeOfEngine = typeOfEngine;
            Price = price;
        }
        public string Driving() => "Машина едет";
    }
}
