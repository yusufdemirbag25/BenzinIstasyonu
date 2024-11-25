
namespace BenzinIstasyonu.service
{
    internal interface IFuelService
    {
        void fuelStart();

        
        void updatePrice(double newPrice);

       
        void updateFuelLevel(double liter);

       
        int fuelTypeSet(FuelService.fuelType type);

       
        bool transferFuel(bool confing);
    }
}
