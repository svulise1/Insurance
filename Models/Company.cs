using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Models
{
    [Table("Companies")]
    public class Company
    {   
        public int Id { get; set; }
       
        public string Name { get; set; }

        public ICollection<InsType> Types { get; set; }

        public Company()
        {
            Types = new Collection<InsType>();
        }
    }
}
