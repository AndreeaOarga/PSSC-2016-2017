using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Student:
    {
        public string nume;
        public string prenume;
        public DateTime data_nasterii;
        public int varsta;
        public string cnp;
        public string adresa;
        public string telefon;
        public int an;

        public Student(string nume, string prenume, DateTime data_nasterii, int varsta, string cnp, string adresa, string telefon, int an)
        {
             this.nume = nume;
             this.prenume = prenume;
             this.data_nasterii = data_nasterii;
             this.varsta=varsta;
             this.adresa = adresa;
             this.telefon = telefon;
             this.an = an;
         }
    }
}
