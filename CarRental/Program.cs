using CarRental.Entities;
using CarRental.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
            
            Console.Write("Preço/Hora: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Preço/Dia: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarsRental carsRental = new CarsRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);
            rentalService.ProcessInvoice(carsRental);
            Console.WriteLine("PAGAMENTO:");
            Console.WriteLine(carsRental.Invoice);
        }
    }
}
