using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Svratiste.Model
{
    public class Evaluation
    {
        public Guid Id { get; set; }
        public Carton Carton { get; set; }
        public String AddressStreetName { get; set; }
        public String AddressStreetNumber { get; set; }

        // TODO: Add other fields
    }
}
