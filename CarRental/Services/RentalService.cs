using CarRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Services {
    public class RentalService {
        // Attributes
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        // Constructors
        public RentalService(double pricePerHour, double pricePerDay) {
        PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        // Methods
        public void ProcessInvoice(CarsRental carsRental) {

        }
    }
}
