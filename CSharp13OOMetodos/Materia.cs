using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos
{
    internal class Materia
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public double CalcularMedia()
        {
            double media = (Nota1 + Nota2 + Nota3) / 3.0;
            return media;
        }

        public string ObterStatus()
        {
            double media = CalcularMedia();
            string statusLogica;

            if (media < 5)
            {
                statusLogica = "Reprovado";
            }
            else if (media < 7)
            {
                statusLogica = "Em Exame";
            }
            else
            {
                statusLogica = "Aprovado";
            }
            return statusLogica;
        }
    }
}
