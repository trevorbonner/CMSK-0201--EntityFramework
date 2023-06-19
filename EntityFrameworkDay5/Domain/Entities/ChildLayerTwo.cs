using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ChildLayerTwo : Entity
    {
        public Guid ChildLayerOneId { get; set; }
        public ChildLayerOne ChildLayerOne { get; set; }
    }
}
