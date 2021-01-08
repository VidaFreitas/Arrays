using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var funcionarios = new Funcionario[5];
            funcionarios[0] = new Funcionario() { Id = 2579 };

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario.Id);
            }
        }
    }
    public struct Funcionario
    {
        public int Id { get; set; }
    }
}
