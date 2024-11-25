
using BenzinIstasyonu.model;
using BenzinIstasyonu.repo;

namespace BenzinIstasyonu.service
{
    internal class CustomerService
    {
        Customer customer = new Customer();
        CustomerDB custDB = new CustomerDB();

      
        public void welcomeCust (string plate, int liter, bool auto)
        {
            customer.autoFill = auto;
            customer.wantedLiter = liter;
            customer.plateNumber = plate;
            custDB.saveCust (customer);
        }
        

        

    }
}
