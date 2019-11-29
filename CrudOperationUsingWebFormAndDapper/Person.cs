using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationUsingWebFormAndDapper
{
   public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string info {
            get
            {
                //return in the format name and age
                return $"{Name} {Age}";
            }
        }

    }
}
