using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    class Seminary
    {
        public String name { get; internal set; }
        internal Seminary(String denum)
        {
            name = denum;
        }

        public override string ToString()
        {
            return name.ToString();
        }
    }
}
