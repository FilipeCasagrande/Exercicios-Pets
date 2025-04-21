using System.Runtime.CompilerServices;

namespace Exercicios_Pets
{
    public class Pet
    {
        public string nome;
        public string tipo;
        public int idade;

        public void Animal()
        {
            Console.WriteLine("informe o nome");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o tipo de animal");
            tipo = Console.ReadLine();

            Console.WriteLine("informe a idade do animal");
            idade = Convert.ToInt32(Console.ReadLine());
        }

        public void exibirPet()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Informaçoes do: " + nome);
            Console.WriteLine($"Nome do animal é: {nome} ");
            Console.WriteLine($"Tipo de animal é: {tipo} ");
            Console.WriteLine($"Idade do animal é: {idade} ");
        }
    }
}








