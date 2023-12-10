namespace CSharp15ForComVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int tam = 4;
            string[] nome = new string[tam];
            double[] notas1 = new double[tam];
            double[] notas2 = new double[tam];
            double[] notas3 = new double[tam];
            double[] medias = new double[tam];

            for(int i = 0; i < tam; i++)
            {
                Console.Write("Informe o nome do aluno: ");
                nome[i] = Console.ReadLine();
                Console.Write("Informe a nota 1: ");
                notas1[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a nota 2: ");
                notas2[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Informe a nota 3: ");
                notas3[i] = Convert.ToDouble(Console.ReadLine());
            }
            for(int i = 0; i < tam; i++)
            {
                medias[i] = (notas1[i] + notas2[i] + notas3[i]) / 3;
            }

            for(int i = 0; i < tam; i++)
            {
                Console.WriteLine("Média do aluno " + (i+1) + ": " + medias[i]);
            }
        }
    }
}
// Solocitar para 4 alunos(obrigatório utilização for) 
// nome 
// nota 1  
// nota 2 
// nota 3 
// apresenta média dos alunos