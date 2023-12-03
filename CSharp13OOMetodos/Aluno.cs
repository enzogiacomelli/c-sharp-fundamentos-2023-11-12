

namespace CSharp13OOMetodos
{
    internal class Aluno
    {
        public double LogicaNota1 { get; set; }
        public double LogicaNota2 { get; set; }
        public double LogicaNota3 { get; set; }
        public double BancoDadosNota1 { get; set; }
        public double BancoDadosNota2 { get; set; }
        public double BancoDadosNota3 { get; set; }

        public double CalcularMediaLogica()
        {
            double media = (LogicaNota1 + LogicaNota2 + LogicaNota3) / 3.0;
            return media;
        }

        public double CalcularMediaBancoDados()
        {
            double media = (BancoDadosNota1 + BancoDadosNota2 + BancoDadosNota3) / 3.0;
            return media;
        }

        public string ObterStatusLogica()
        {
            double media = CalcularMediaLogica();
            string statusLogica;

            if(media <5)
            {
                statusLogica = "Reprovado";
            }
            else if(media < 7)
            {
                statusLogica = "Em Exame";
            }
            else
            {
                statusLogica = "Aprovado";
            }
            return statusLogica;
        }

        public string ObterStatusBancoDados()
        {
            double media = CalcularMediaBancoDados();
            string statusBanco;

            if (media < 5)
            {
                statusBanco = "Reprovado";
            }
            else if (media < 7)
            {
                statusBanco = "Em Exame";
            }
            else
            {
                statusBanco = "Aprovado";
            }
            return statusBanco;
        }

        public string ObterStatus()
        {
            string status = "Situação em Logica: " + ObterStatusLogica() + " \n" + "Situação em Banco de dados: " + ObterStatusBancoDados() + "\n";
            return status;
        }
    }
}
