using CarRental.Entities;
using System;

namespace CarRental.Services {
    public class RentalService {
        // Attributes
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private BrazilianTaxServices _brazilianTaxServices = new BrazilianTaxServices();

        // Constructors
        public RentalService(double pricePerHour, double pricePerDay) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        // Methods
        public void ProcessInvoice(CarsRental carsRental) {
            TimeSpan duration = carsRental.Finish.Subtract(carsRental.Start);
            double basicPayment = 0.0;
            if (duration.TotalHours <= 12) {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            } else {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _brazilianTaxServices.Tax(basicPayment);
            carsRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
