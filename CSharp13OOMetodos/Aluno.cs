

namespace CSharp13OOMetodos
{
    internal class Aluno
    {
        public Materia Logica { get; set; }
        public Materia BancoDados { get; set; }
        

        public string ObterStatus()
        {
            string status = "Situação em Logica: " + Logica.ObterStatus() + " \n" + "Situação em Banco de dados: " + BancoDados.ObterStatus() + "\n";
            return status;
        }
    }
}
