using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? ModifiedId { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public int Status { get; set; }
        [Timestamp]
        public TimeSpan TimeSpan { get; set; }
    }
}
