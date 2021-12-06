using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Cachorro : ClasseAnimal
    {
        public Cachorro(string nome, string raca, int patas)
        {
            this.nome = nome;
            this.raca = raca;
            this.patas = patas;
        }

        public Cachorro()
        {
            this.nome = "";
            this.raca = "";
            this.patas = 0;
        }

        public override void Mostrar()
        {
            Console.WriteLine(nome);
            Console.WriteLine(raca);
            Console.WriteLine(patas);
        }
        public override string morder()
        {
            return "o cachorro esta mordendo";
        }
        public override string mover()
        {
            return "o cachorro esta movendo";
        }

    }
}
