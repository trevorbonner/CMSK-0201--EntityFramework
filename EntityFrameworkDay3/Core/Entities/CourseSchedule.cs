using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    [Table("Schedule", Schema ="daythree")]
    public class CourseSchedule : Entity
    {
        public Guid CourseId { get; set; }
        public Course Course { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Column("Latest", Order = 2)]
        public bool IsLatest { get; set; }
    }
}
