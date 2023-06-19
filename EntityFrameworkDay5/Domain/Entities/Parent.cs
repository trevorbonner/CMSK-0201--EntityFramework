using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Parent : Entity
    {
        public Parent()
        {
            Children = new List<ChildLayerOne>();
        }

        public List<ChildLayerOne> Children { get; set; }
    }
}
