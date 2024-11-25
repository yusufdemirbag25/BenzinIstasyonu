
using BenzinIstasyonu.model;

namespace BenzinIstasyonu.repo
{
    internal class FuelDB
    {
        public static List<Fuel> fuelList { get; set; }

        public FuelDB()
        {
            fuelList = new List<Fuel>();
        }

        public void addFuel(Fuel fuel)
        {
            fuelList.Add(fuel);
        }
    }
}
