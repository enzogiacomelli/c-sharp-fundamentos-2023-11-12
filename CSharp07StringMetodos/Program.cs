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