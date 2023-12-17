namespace CSharp16ListasTiposPrimitivos
{
    internal class Exercicio01
    {
        public void Executar()
        {
            List<Alunos> alunos = new List<Alunos>();


            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Editar");
            Console.WriteLine("3 - Apagar");
            Console.WriteLine("4 - Listar Médias");
            Console.WriteLine("10 - Sair");
            Console.Write("Digite o menu desejado: ");
            int menu = Convert.ToInt32(Console.ReadLine());

            while (menu != 10)
            {
                Console.Clear();

                if (menu == 1)
                {
                    Alunos aluno = new Alunos();
                    aluno.Cadastrar();
                    alunos.Add(aluno);
                }

                else if(menu == 2)
                {
                    Console.Write("Digite o nome do aluno para ser editado: ");
                    string nome = Console.ReadLine();
                    Alunos aluno = alunos.SingleOrDefault(x => x.Nome == nome);
                    aluno.Editar();
                    Console.ReadLine();
                }
                else if (menu == 3)
                {
                    Console.Write("Digite o nome do aluno para ser apagado: ");
                    string nome = Console.ReadLine();
                    Alunos aluno = alunos.SingleOrDefault(x => x.Nome == nome);
                    alunos.Remove(aluno);
                    Console.Write("\nAluno Removido!");
                    Console.ReadLine();
                }
                else if (menu == 4)
                {
                    Console.WriteLine("Médias dos alunos: \n");
                    for(int i=0; i < alunos.Count; i++)
                    {
                        Console.WriteLine("Aluno: " + alunos[i].Nome);
                        Console.WriteLine("Média: " + alunos[i].CalculaMedia());
                        Console.Write("\n");
                    }
                    Console.ReadLine();
                }
                Console.Clear();
                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Editar");
                Console.WriteLine("3 - Apagar");
                Console.WriteLine("4 - Listar Médias");
                Console.WriteLine("10 - Sair");
                Console.Write("Digite o menu desejado: ");
                menu = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
