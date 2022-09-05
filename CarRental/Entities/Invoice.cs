using CarRental.Services;
using System.Globalization;

namespace CarRental.Entities {
    public class Invoice {
        // Attributes
        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        
        // Constructors
        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment { get { return BasicPayment + Tax; } }

        // Methods
        public override string ToString() {
            return $"Valor inicial: {BasicPayment.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nTaxa: {Tax.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nValor total: {TotalPayment.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
