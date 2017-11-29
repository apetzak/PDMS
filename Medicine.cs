using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    class Medicine
    {
        public string Name;
        public int Price;
        public int CasePrice;
        public DateTime ExpireDate;
        public int ShipmentNumber;
        public int Quantity;

        public Medicine(string name, int price, int casePrice, DateTime expireDate, int shipmentNumber, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.CasePrice = casePrice;
            this.ExpireDate = expireDate;
            this.ShipmentNumber = shipmentNumber;
            this.Quantity = quantity;
        }
    }
}
