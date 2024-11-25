

using BenzinIstasyonu.model;

namespace BenzinIstasyonu.repo
{
    internal class PumpDB
    {
        public List<Pump> pumpList =new List<Pump>();

        
        public PumpDB()
        {
            pumpList = new List<Pump>();

            
            for (int i = 1; i <= 10; i++)
            {
                pumpList.Add(new Pump(i));
            }
        }
    }
}
