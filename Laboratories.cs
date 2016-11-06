using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models.Subject
{
    class Laboratories
    {
        private List<Laboratory> _labs;
         public ReadOnlyCollection<Laboratory> Valori { get { return _labs.AsReadOnly(); } }
 
         internal Laboratories()
         {
             _labs = new List<Laboratory>();
         }
 
         internal Laboratories(List<Laboratory> laboratoare){
             Contract.Requires(laboratoare != null, "lista de laboratoare");
             _labs = laboratoare;
         }
 
         internal void AdaugaLaborator(Laboratory laborator){
             Contract.Requires(laborator != null, "laborator");
             _labs.Add(laborator);
         }
 
         public override string ToString()
         {
             return _labs.Aggregate(new StringBuilder(), (builder, laborator) => {
                 if (builder.Length > 0) builder.Append(", ");
                 builder.Append(laborator);
                 return builder;
             }).ToString();
         }
    }
}









