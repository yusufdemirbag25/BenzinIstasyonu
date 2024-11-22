
using BenzinIstasyonu.model;

namespace BenzinIstasyonu.service
{
    internal class CustomerService
    {
        Customer customer = new Customer();


        public int fuelType (int fuelType)
        {
            if (fuelType == 1)
            {
                return 1;
            }

            else if (fuelType == 2)
            {
                return 2;
            }

            else (fuelType == 3)
            {
                return 3;
            }
        }
        public void customerWelcome(string Plate, int Liter, bool autofill)
        {
            customer.plateNumber = Plate;
            customer.autoFill = autofill;
            customer.wantedLiter = Liter;

        }

        

    }
}
