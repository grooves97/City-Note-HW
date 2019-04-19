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
        public string Code { get; set; }
        public List<PhoneNumber> Numbers { get; set; }
    }
}
