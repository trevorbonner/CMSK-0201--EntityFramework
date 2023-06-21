using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Address : Entity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public string Email { get; set; }
    }
}
