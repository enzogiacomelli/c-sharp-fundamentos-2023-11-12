string texto = "       ola mundo, aula de c#  ";
Console.WriteLine("texto original: " + texto);

//int quantidadeCaracteres = texto.Length;
Console.WriteLine("Quantidade de caracteres original: " + texto.Length);



//string textoFormatado = texto.Replace(" ", "");
texto = texto.TrimStart();
texto = texto.TrimEnd();
Console.WriteLine("texto formatado: " + texto);
Console.WriteLine("Quantidade de caracteres após formatar: " + texto.Length);

/*  outros comandos de string:
texto.ToUpper();
texto.ToLower();
texto.StartsWith("a");
texto.EndsWith("b");
texto.Contains("c");
texto.Replace("a", "b");
*/


//pegando apenas o primeiro nome em uma string com o nome completo:
string nomeCompleto = "Enzo Giacomelli";
int indiceEspaco = nomeCompleto.IndexOf(" "); //pega a posição onde está o espaço
string nome =  nomeCompleto.Substring(0, indiceEspaco); //pega do primeiro indice até o indice do espaço
Console.WriteLine("\n\nNome: " + nome); //deve escrever apenas o primeiro nome

//pegando o ultimo nome
int indiceUltimoEspaco = nomeCompleto.LastIndexOf(" ");//pega o indice do ultimo espaço em caso de nome composto
int quantidadeCaracteresUltimoNome = nomeCompleto.Length - indiceUltimoEspaco; //pega o tamanho do ultimo nome
string ultimoNome = nomeCompleto.Substring(indiceUltimoEspaco, quantidadeCaracteresUltimoNome);// pega o texto do ultimo espaço até o fim do ultimo nome
Console.WriteLine("Ultimo nome: " + ultimoNome);