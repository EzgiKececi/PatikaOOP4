using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PatikaOOP4
{
    public class Car
    {
        private string _brand;
        private string _model;
        private string _colour;
        private int _numberOfDoor;

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }

        public Car(string brand, string model, string colour, int numberOfDoor)
        {
            Brand = brand;
            Model = model;
            Colour = colour;
            NumberOfDoor = numberOfDoor;
        }
        public int NumberOfDoor
        {
            get { return _numberOfDoor; }
            set
            {
                if (value == 2 || value == 4) // Aracın 2 veya 4 kapılı olmasına göre ekrana bilgi verme 
                {
                    _numberOfDoor = value;
                    Console.WriteLine($"{Brand} {Model} marka ve modelindeki {Colour} renkli araç {NumberOfDoor} kapılıdır.");
                }


                else
                {
                    Console.WriteLine($"{Brand} {Model} marka ve modelindeki araç için kapı sayısını 2 veya 4 dışında bir değer giremezsiniz.");
                    _numberOfDoor = -1;
                    Console.WriteLine($"Kapı Sayısı Değeri: {_numberOfDoor}");
                }




            }

        }
    }
}