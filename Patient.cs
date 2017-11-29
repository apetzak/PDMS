using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDMS
{
    class Patient
    {
        public string FirstName;
        public string LastName;
        public DateTime DateOfBirth;
        public string Prescription;
        public string Insurance;
        public DateTime LastVisitDate;

        public Patient(string fName, string lName, DateTime dob, string prescription, string insurance, DateTime lastVisitDate)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.DateOfBirth = dob;
            this.Prescription = prescription;
            this.Insurance = insurance;
            this.LastVisitDate = lastVisitDate;
        }
    }
}
