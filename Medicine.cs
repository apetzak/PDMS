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
        public decimal Price;
        public decimal CasePrice;
        public int ExpirationDay;
        public int ShipmentNumber;
        public int Quantity;

        public Medicine(string name, decimal price, decimal casePrice, int expirationDay, int shipmentNumber, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.CasePrice = casePrice;
            this.ExpirationDay = expirationDay;
            this.ShipmentNumber = shipmentNumber;
            this.Quantity = quantity;
        }
    }
}
