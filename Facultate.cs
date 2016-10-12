using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Facultate: Universitate
    {
         public int id_facultate;
         public string nume_facultate;
         private int id_facultate1;
         private string nume_facultate1;
         

         public Facultate(int id_universitate, string nume_universitate,  int id_facultate,string nume_facultate):
             base(id_universitate, nume_universitate)
         {
             this.nume_facultate = nume_facultate;
             this.id_facultate = id_facultate;
             
         }

    }
}
