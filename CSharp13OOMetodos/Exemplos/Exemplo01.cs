using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13OOMetodos.Exemplos
{
    internal class Exemplo01
    {
        public void Executar()
        {
            Cachorro dog = new Cachorro();

            dog.Nome = "abbie";
            dog.Idade = 1;
            dog.Raca = "vira-lata";
            dog.Sexo = "Feminino";

            Cachorro dogao = new Cachorro();
            dogao.Nome = "bacon";
            dogao.Sexo = "masculino";
            dogao.Raca = "vira-lata";
            dogao.Idade = 6;

            Console.WriteLine("Nome: " + dog.Nome);
            Console.WriteLine("Idade: " + dog.Idade);
            Console.WriteLine("Raça: " + dog.Raca);
            Console.WriteLine("Sexo: " + dog.Sexo);


            int soma = dog.Idade + dogao.Idade;
            double media = soma / 2.0;
            Console.WriteLine(media);
        }
    }
}
