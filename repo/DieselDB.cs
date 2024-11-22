
using BenzinIstasyonu.model;

namespace BenzinIstasyonu.repo
{
    internal class DieselDB
    {


        public List<Diesel> dieselList { get; set; }

        public DieselDB()
        {
            dieselList = new List<Diesel>();
        }

        public void AddDiesel(Diesel diesel)
        {
            dieselList.Add(diesel);
           
        }


    }
}
