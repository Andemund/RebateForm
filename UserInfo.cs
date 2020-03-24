using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class UserInfo
    {
        public string UserID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdderss { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string ReceiveDate { get; set; }
        public string PoofAttach { get; set; }
        public string StartTime { get; set; }
        public string SaveTime { get; set; }
        public string BackNum { get; set; }
        public string Get_full_name()
        {
            string full_name = "";
            full_name = FirstName + " " + MiddleName + " " + LastName;
            return full_name;
        }
    }
}
