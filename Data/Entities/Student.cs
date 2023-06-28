using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Student : Entity
    {
        public Student()
        {
            Addresses = new List<Address>();
        }

        public virtual List<Address> Addresses { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
