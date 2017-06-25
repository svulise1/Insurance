using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Models
{
   
    public class InsType
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public Company Company { get; set; }

        public int CompanyId { get; set; }
    }
}
