using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos deseja reservar? ");
            int n = int.Parse(Console.ReadLine());

            Estudante[] vect  = new Estudante[10];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"aluguel #{i}");
                Console.WriteLine("digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.WriteLine("digite o email do aluno: ");
                string email = Console.ReadLine();

                Console.WriteLine("Quarto: ");

                 int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }

            Console.WriteLine("quartos ocupados: ");
            for(int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }

            }
        }
    }
}