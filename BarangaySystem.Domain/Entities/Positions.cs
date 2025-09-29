using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarangaySystem.Domain.Entities
{
    public class Positions
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
}
