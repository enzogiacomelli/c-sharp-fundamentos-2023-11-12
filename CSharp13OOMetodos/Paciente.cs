
namespace CSharp13OOMetodos
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }
        public int Idade { get; set; }

        public double CalcularImc()
        {
            double imc = Peso / (Altura * Altura);
            return imc;
        }

        public string ObterClassificacaoImc()
        {
            double imc = CalcularImc();
            string classificacao = "";

            if(imc < 18.5)
            {
                classificacao = "Baixo Peso";
            }
            else if(imc < 25)
            {
                classificacao = "Peso Normal";
            }
            else if(imc < 30)
            {
                classificacao = "Excesso de Peso";
            }
            else if(imc < 35)
            {
                classificacao = "Obesidade";
            }
            else
            {
                classificacao = "Obesidade Extrema";
            }
            return classificacao;
        }

        public string ObterClassificacaoGeracao()
        {
            int anoNascimento = 2023 - Idade;
            string geracao = "";

            if(anoNascimento < 1960)
            {
                geracao = "Baby Boomers";
            }
            else if(anoNascimento < 1980)
            {
                geracao = "Geração X";
            }
            else if(anoNascimento < 1995)
            {
                geracao = "Geração Y";
            }
            else if(anoNascimento < 2010)
            {
                geracao = "Geração Z";
            }
            else
            {
                geracao = "Geração Alpha";
            }
            return geracao;
        }
    }
}
