
namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo03
    {
        public void Executar()
        {
            Paciente paciente01 = new Paciente();

            Console.Write("Nome: ");
            paciente01.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            paciente01.Idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Altura: ");
            paciente01.Altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso: ");
            paciente01.Peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("CPF: ");
            paciente01.Cpf = Console.ReadLine();

            double imcPaciente01 = paciente01.CalcularImc();
            string classificacaoImc = paciente01.ObterClassificacaoImc();
            string geracaoPaciente1 = paciente01.ObterClassificacaoGeracao();

            Console.WriteLine("IMC do paciente: " + imcPaciente01);
            Console.WriteLine("Classificação do paciente 1: " + classificacaoImc);
            Console.WriteLine("Geração do paciente 1: " + geracaoPaciente1);
        }
    }
}
