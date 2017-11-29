using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    class Branch
    {
        public string Name;
        public string Address;
        public List<Medicine> Inventory;
        public List<string> StockableMedicines;
        public DateTime EarliestExpireDate;
        public DateTime DefaultExpectedDelivery;

        public Branch(string name, string address, List<Medicine> inventory, List<string> stockableMedicine, DateTime expireDate, DateTime defaultDelivery)
        {
            this.Name = name;
            this.Address = address;
            this.Inventory = inventory;
            this.StockableMedicines = stockableMedicine;
            this.EarliestExpireDate = expireDate;
            this.DefaultExpectedDelivery = defaultDelivery;
        }
    }
}
