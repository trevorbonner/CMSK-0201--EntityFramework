using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Student : Entity
    {
        public Student()
        {
            Addresses = new List<Address>();
        }

        List<Address> Addresses { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
    }
}
