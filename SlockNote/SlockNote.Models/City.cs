using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlockNote.Models
{
    public class City : Entity
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public virtual ICollection<PhoneNumber> Numbers { get; set; }
    }
}
