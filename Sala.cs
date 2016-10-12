using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class Sala
    {
         public int id_sala;
         public string zi;
         public string ora;
         public int an_studiu;
 
         public Sala(int id_sala,string zi, string ora, int an_studiu)
         {
             this.id_sala = id_sala;
             this.zi = zi;
             this.ora = ora;
             this.an_studiu = an_studiu;
         }
    }
}
