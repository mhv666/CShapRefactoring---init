using CShapRefactoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapRefactoring
{
    class Principal
    {
        static void Main (String[] args)
        {
         Cliente cli1 = new Cliente("Marti");
         Pelicula pel1 = new Pelicula("ave",1);
         Renta ren1 = new Renta(pel1,7);

            cli1.addRenta(ren1);
            cli1.emitirReciboRenta();
            
          
        }
        
        
        
    }
}
