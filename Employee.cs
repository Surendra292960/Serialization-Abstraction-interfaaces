using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization.Serialization
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> Hobbies { set; get; }

        public override string ToString()
        {
            return string.Format("Employee Information:\n\tId:{0}, Name:{1}, Address:{2}, Hobbies:{3}", Id, Name, Address, string.Join(",", Hobbies.ToArray()));
        }
    }
}
