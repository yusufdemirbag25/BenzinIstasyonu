

using BenzinIstasyonu.model;
using BenzinIstasyonu.repo;

namespace BenzinIstasyonu.service
{
    internal class DieselService
    {
        DieselDB dieselDB = new DieselDB(); 
        Diesel diesel = new Diesel();
        Customer dieselcust = new Customer();
        public void dieselStart(int remaining, int literPrice, string type)
        {
            diesel.remainDiesel = 6500;
            diesel.literPriceD = 45;
            diesel.dieselType = "Motorin";
            dieselDB.AddDiesel(diesel);
        }

        public int dieselLiterSet (int liter)
        {
            diesel.remainDiesel = liter;
            return diesel.remainDiesel;
        }
        public int dieselPriceSet (int price)
        {
            diesel.remainDiesel = price;
            return diesel.remainDiesel;
        }

        public string dieselTypeSet (string type)
        {
            diesel.dieselType = type;
            return diesel.dieselType;
        }

        public bool transferDiesel(bool confing)
        {
            if (dieselcust.wantedLiter < diesel.remainDiesel )
            {
                diesel.remainDiesel = diesel.remainDiesel - dieselcust.wantedLiter;
                return true;
            }
            return false;
        }
    }
}
