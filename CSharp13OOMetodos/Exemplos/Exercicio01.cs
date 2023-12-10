using CSharp13OOMetodos;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            Aluno aluno1 = new Aluno(); //criando objeto aluno
            aluno1.Logica = new Materia(); //o objeto aluno possui propriedades do tipo Materia(classe)
            aluno1.BancoDados = new Materia(); //devem ser instanciados os objetos referentes as propriedades do objeto aluno


            Console.Write("Nota de logica 1: ");
            aluno1.Logica.Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de logica 2: ");
            aluno1.Logica.Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de logica 3: ");
            aluno1.Logica.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de banco de dados 1: ");
            aluno1.BancoDados.Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de banco de dados 2: ");
            aluno1.BancoDados.Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota de banco de dados 3: ");
            aluno1.BancoDados.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Status do aluno: \n" + aluno1.ObterStatus());
        }
    }
}
