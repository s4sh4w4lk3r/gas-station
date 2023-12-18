using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation.Entities
{
    internal class Deliverer
    {
        public int Id { get; set; }
        public required string FIO { get; set; }
        public required string PhoneNumber { get; set; }
    }
}
