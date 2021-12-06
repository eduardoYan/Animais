using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
     abstract class ClasseAnimal : IAcoesDosAnimais
    {
        public  ClasseAnimal()
        {
            
        }
        public string nome { get; set; }
        public string raca { get; set; }
        public int patas{ get; set; }
        public abstract string morder();
        public abstract string mover();
        public abstract void Mostrar();
    }
}
