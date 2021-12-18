using System;
using System.Collections.Generic;
using System.Text;

namespace MVVMsteps.Model
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{FirstName[0]}. {LastName}: {PhoneNumber}";

        }
    }
}
