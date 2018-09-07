using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SafeHouse.Model
{
    public class Evaluation : BaseEntity
    {
        public Carton Carton { get; set; }

        // TODO: Add other fields
    }
}
