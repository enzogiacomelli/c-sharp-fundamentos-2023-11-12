namespace CSharp15ForComVetor
{
    internal class exemplo00
    {
        public void Executar()
        {
            string[] nomes = new string[3];
            string[] sobrenomes = new string[3];

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();
                Console.Write("Sobrenome: ");
                sobrenomes[i] = Console.ReadLine();
            }

            Console.Clear();
            for (int i = 0; i < nomes.Length; i++)
            {
                string nomeCompleto = nomes[i] + sobrenomes[i];
                Console.WriteLine("Nome Completo: " + nomeCompleto);
            }
        }
    }
}
