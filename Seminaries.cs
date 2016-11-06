using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    class Seminaries
    {
        private List<Seminary> _seminaries;
         public ReadOnlyCollection<Seminary> Valori { get { return _seminaries.AsReadOnly(); } }
 
         internal Seminaries()
         {
             _seminaries = new List<Seminary>();
         }
 
         internal Seminaries(List<Seminary> seminarii)
         {
             Contract.Requires(seminarii != null, "List of seminaries");
             _seminaries = seminarii;
         }
 
         internal void AdaugaSeminar(Seminary seminar)
         {
            Contract.Requires(seminar != null, "seminary");
             _seminaries.Add(seminar);
         }
 
         public override string ToString()
         {
             return _seminaries.Aggregate(new StringBuilder(), (builder, seminar) =>
             {
                 if (builder.Length > 0) builder.Append(", ");
                 builder.Append(seminar);
                 return builder;
             }).ToString();
         }
    }
}
