

using BenzinIstasyonu.model;
using BenzinIstasyonu.repo;
using System.Linq.Expressions;

namespace BenzinIstasyonu.service
{
    internal class FuelService : IFuelService
    {
        FuelDB fuelDB = new FuelDB();
        Fuel fuel;
        Customer cust = new Customer();
        PumpService pumpService;
        public void fuelStart()
        {
            fuel.remainFuel = 6500;
            fuel.literPriceD = 45;
            fuel.fuelType = 2;
            fuelDB.addFuel(fuel);
        }

        public void updatePrice(double newPrice)
        {
            fuel.literPriceD = newPrice;
        }

        public void updateFuelLevel(double liter)
        {
            fuel.remainFuel += liter;
        }

        public int fuelTypeSet(fuelType type)
        {
            fuel.fuelType = (int)type;
            return fuel.fuelType;
        }

        public bool transferFuel(bool confing)
        {
            if (cust.wantedLiter <= fuel.remainFuel)
            {
                fuel.remainFuel -= cust.wantedLiter;
                return true;
            }
            else
            {
                Console.WriteLine("Yetersiz yakıt!");
                return false;
            }
        }

     

        public enum fuelType
        {
            Benzin = 1,
            Motorin = 2,
            LPG = 3
        }
    }
}
