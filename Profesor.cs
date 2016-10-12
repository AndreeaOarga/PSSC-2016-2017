using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Profesor
    {
        public string nume;
        public string prenume;
        public int vechime;
        public string materie;
        
        public Profesor(string nume, string prenume, int vechime, string materie)
        {
             this.nume = nume;
             this.prenume = prenume;
             this.vechime = vechime;
             this.materie = materie;
         }
    }
}
