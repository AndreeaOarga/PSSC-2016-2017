using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    class Laboratory
    {
         public String name { get; internal set; }
 
         internal Laboratory(String denum)
         {
             name = denum;
         }
 
 
        public override string ToString()
         {
              return name.ToString();
        }
    }
}
