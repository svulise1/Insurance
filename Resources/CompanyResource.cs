using Insurance.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Resources
{
    public class CompanyResource
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<InsTypeResource> Types { get; set; }

        public CompanyResource()
        {
            Types = new Collection<InsTypeResource>();
        }
    }
}
