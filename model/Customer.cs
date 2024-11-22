
namespace BenzinIstasyonu.model
{
    internal class Customer
    {
        public string plateNumber { get; set; }
        public int wantedLiter { get; set; }
        public bool autoFill { get; set; }

        public  int fuelType { get; set; }
    }
}
