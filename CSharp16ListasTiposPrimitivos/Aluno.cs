namespace CSharp16ListasTiposPrimitivos
{
    internal class Alunos
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalculaMedia()
        {
            double media = (Nota1 + Nota2 + Nota3) / 3;

            return media;
        }

        public void Cadastrar()
        {
            Console.Write("Digite o nome do aluno: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a nota 1: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 1: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 1: ");
            Nota3 = Convert.ToDouble(Console.ReadLine());
        }

        public void Editar()
        {
            Console.Write("Digite o nome para edição: ");
            Nome = Console.ReadLine();

            Console.Write("Digite a nota 1 para edição: ");
            Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 1 para edição: ");
            Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota 1 para edição: ");
            Nota3 = Convert.ToDouble(Console.ReadLine());
        }
    }
}
