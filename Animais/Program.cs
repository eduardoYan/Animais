using System;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato g1 = new Gato("joaozinho", "laranja", 4);
            g1.Mostrar();
            g1.morder();
            g1.mover();
            Cachorro C1 = new Cachorro();
            Console.WriteLine("coloque o nome do cachorro");
            C1.nome = Console.ReadLine();
            Console.WriteLine("coloque a raca do " + C1.nome);
            C1.raca = Console.ReadLine();
            
            while (C1.patas == 0 ) {
                try
                {
                    Console.WriteLine("Agora coloque quantas patas tem o animal ");
                    C1.patas = Convert.ToInt32(Console.ReadLine());

                }

                catch
                {
                    Console.WriteLine("o formato nao foi aceito =/ ");
                }
                
            }

            C1.Mostrar();
            Console.ReadKey();
        }
    }
}
