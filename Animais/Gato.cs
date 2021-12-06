using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
    class Gato : ClasseAnimal
    {
        /*public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetRaca(string raca)
        {
            this.raca = raca;
        }
        public void SetPatas(int patas)
        {
            this.patas = patas;
        }
        
        public int GetPatas()
        {
            return patas;
        }
        public string GetNome()
        {
            return nome;
        }

        public string GetRaca()
        {
            return raca;
        }
        */


        public Gato()
        {
            this.nome = "";
            this.raca = "";
            this.patas = 0;
        }
        public Gato(string nome, string raca, int patas)
        {

            this.nome = nome;
            this.raca = raca;
            this.patas = patas;
        }


        public override void Mostrar()
        {
            Console.WriteLine(nome);
            Console.WriteLine(raca);
            Console.WriteLine(patas);

        }

        public override string morder()
        {
            return "o gato esta mordendo";
        }
        public override string mover()
        {
            return "o gato esta movendo";
        }
        
        
    }
}
