using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Exercicios_Pets
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Pet animal1 = new Pet();
            animal1.Animal();
            Console.WriteLine("-------------------------------");

            Pet animal2 = new Pet();
            animal2.Animal();

            Console.WriteLine("-------------------------------");

            animal1.exibirPet();
            animal2.exibirPet();

            Console.ReadLine();





        }

    }
}
