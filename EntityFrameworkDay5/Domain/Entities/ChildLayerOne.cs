using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ChildLayerOne : Entity
    {
        public ChildLayerOne()
        {
            Children = new List<ChildLayerTwo>();
        }

        public Guid ParentId { get; set; } //FK Constraint, has to match to Parent record
        public Parent Parent {get;set;} //Only 1 referenced in this class
        public List<ChildLayerTwo> Children { get; set; }

    }
}
