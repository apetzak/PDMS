using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    class Order
    {
        public List<Medicine> Medicines;
        public Patient Patient;
        public DateTime Date;
        public DateTime ExpectedDeliveryDate;
        public DateTime DeliveryDate;
        public string Admin;
        public string Pharmacist;
        public Branch Branch;

        public Order(List<Medicine> medicines, Patient patient, DateTime date, DateTime expectedDelivery, DateTime deliveryDate, string admin, string pharmacist, Branch branch)
        {
            this.Medicines = medicines;
            this.Patient = patient;
            this.Date = date;
            this.ExpectedDeliveryDate = expectedDelivery;
            this.DeliveryDate = deliveryDate;
            this.Admin = admin;
            this.Pharmacist = pharmacist;
            this.Branch = branch;
        }
    }
}
