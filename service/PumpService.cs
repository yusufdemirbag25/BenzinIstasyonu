

using BenzinIstasyonu.model;
using BenzinIstasyonu.repo;

namespace BenzinIstasyonu.service
{
    internal class PumpService
    {
        PumpDB pumpDB = new PumpDB();
        Pump pump;

        public PumpService(int pumpNumber)
        {
            pump = new Pump(pumpNumber);
        }


        public enum pumpSelect
        {
            pump1 = 1,
            pump2 = 2,
            pump3 = 3,
            pump4 = 4,
            pump5 = 5,
            pump6 = 6,
            pump7 = 7,
            pump8 = 8,
            pump9 = 9,
            pump10 = 10,
        }

        public void pumpPick (int pumpIndex)
        {
            pump = PumpDB.pumpList[pumpIndex - 1];
        }
    }
}
