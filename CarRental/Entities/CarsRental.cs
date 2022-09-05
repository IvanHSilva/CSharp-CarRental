using System;

namespace CarRental.Entities {
    public class CarsRental {
        // Attributes
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        // Constructors
        public CarsRental(DateTime start, DateTime finish, Vehicle vehicle) {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
    }
}
