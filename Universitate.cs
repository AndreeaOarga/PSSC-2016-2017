using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Universitate
    {
        public int id_universitate;
        public string nume_universitate;

        public Universitate(int id_universitate, string nume_universitate)
         {
             this.id_universitate = id_universitate;
             this.nume_universitate = nume_universitate;
         }
    }
}
