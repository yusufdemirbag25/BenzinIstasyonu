

using BenzinIstasyonu.model;

namespace BenzinIstasyonu.repo
{
    internal class CustomerDB
    {
        Customer customer = new Customer();


       public List<Customer> custlist = new List<Customer>();


        public void saveCust (Customer cust)
        {
           custlist.Add(cust);
        }
    }
}
