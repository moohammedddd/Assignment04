using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04.Association.Aggeration
{
    internal class Department
    {
        // Departement may have have employee (is optional )
        public int Code { get; set; }
        public required string Name { get; set; }
        public List<Employee>? Employees { get; set; } // make it optional 
    }
}
