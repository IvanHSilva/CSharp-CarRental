using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalApp {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("LOCAÇÃO");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Retirada (dd/mm/aaaa hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Devolução (dd/mm/aaaa hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            CarsRental carsRental = new CarsRental(start, finish, new Vehicle(model));
        }
    }
}
