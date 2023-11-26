
string caminho = "C:\\Users\\egiac\\Desktop\\arquivo.csv"; //especificando caminho e tipo de arquivo


if(File.Exists(caminho) == false) //se o arquivo não existir, executa essa parte
{
    string cabecalho = "Nome;Idade"; //cria o cabeçalho parra a primeira linha do arquivo
    File.WriteAllText(caminho, cabecalho); //esse comando cria um novo arquivo e escreve o conteudo inteiro
}
else
{
    string registros = File.ReadAllText(caminho);
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




