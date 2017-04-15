using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string SSN { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public string EmailAddress { get; set; }
    }
}
