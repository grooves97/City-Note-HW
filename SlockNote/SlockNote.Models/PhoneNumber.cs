using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlockNote.Models
{
    public class PhoneNumber : Entity
    {
        public int Phone { get; set; }
        public Guid Id { get; set; }
        public virtual City City { get; set; }
    }
}
