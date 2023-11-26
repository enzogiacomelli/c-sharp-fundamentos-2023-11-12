using ConsoleTables;

string caminho = "C:\\Users\\egiac\\Desktop\\arquivo.csv"; //especificando caminho e tipo de arquivo


if(File.Exists(caminho) == false) //se o arquivo não existir, executa essa parte
{
    string cabecalho = "Nome;Idade"; //cria o cabeçalho parra a primeira linha do arquivo
    File.WriteAllText(caminho, cabecalho); //esse comando cria um novo arquivo e escreve o conteudo inteiro
}
else
{
    string[] registros = File.ReadAllLines(caminho);// comando que le cada linha do arquivo e retorna um vetor
    int quantidadeRegistros = registros.Length;

    Console.WriteLine("Registros do arquivo.csv");


    ConsoleTable tabela = new ConsoleTable("Nome", "Idade");



    int indice = 0;
    while(indice < quantidadeRegistros)
    {
        if(indice ==0)
        {
            indice++;
            continue;
        }

        string registro = registros[indice];//obter a linha(registro)
        string[] colunas = registro.Split(";");//quebra o registro em um vetor, separando pelo ';'
        string nome = colunas[0];//obter o nome que está na primeira posição do vetor
        int idade = Convert.ToInt32(colunas[1]);//obter a idade que esta na segunda posicao do vetor
        Console.WriteLine(nome + " => " + idade + " anos");
        
        indice++;
    }
}

Console.Write("Deseja cadastrar algum registro? [S/N]");
string desejaContinuar = Console.ReadLine().Trim().ToLower();


while(desejaContinuar == "s")
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();

    Console.Write("\nIdade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    string registro = "\n" + nome + ";" + idade;
    File.AppendAllText(caminho, registro); //comando de Append, adiciona o novo conteudo no final do arquivo

    Console.Write("Deseja continuar? [S/N]");
    desejaContinuar = Console.ReadLine().Trim().ToLower();
}




