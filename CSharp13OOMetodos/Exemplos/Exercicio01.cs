using CSharp13OOMetodos;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Aluno aluno1 = new Aluno();

            Console.Write("Nota de logica 1: ");
            aluno1.LogicaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de logica 2: ");
            aluno1.LogicaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de logica 3: ");
            aluno1.LogicaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de banco de dados 1: ");
            aluno1.BancoDadosNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de banco de dados 2: ");
            aluno1.BancoDadosNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de banco de dados 3: ");
            aluno1.BancoDadosNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Status do aluno: \n" + aluno1.ObterStatus());
        }
    }
}
