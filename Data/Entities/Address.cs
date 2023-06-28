using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Address : Entity
    {
        public virtual Student Student { get; set; }
        public Guid StudentId { get; set; }

        public string EmailAddress { get; set; }
        public bool IsActive { get; set; }
    }
}
