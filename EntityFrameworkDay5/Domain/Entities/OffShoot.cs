using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OffShoot : Entity
    {
        public Guid ParentId { get; set; }//FK to Parent table
        public Parent Parent { get; set; }
        public Guid ChildLayerOneId { get; set; } //FK to ChildLayerOne table
        public ChildLayerOne ChildLayerOne { get; set; }
    }
}
