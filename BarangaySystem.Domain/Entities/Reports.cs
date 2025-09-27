using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarangaySystem.Domain.Entities
{
    public class Reports
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }   
        public string Type { get; set; }
        public DateTime createdAt { get; set; } 
        public DateTime updatedAt { get; set; } 
        

    }
}
