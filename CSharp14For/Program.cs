
//int indice = 0;
//while(indice < 5)
//{
//    Console.WriteLine("Mensagem com while");
//    indice++;
//}
//Console.WriteLine("Fim do while");


//for(int indice2 = 0; indice2 < 5; indice2++)
//{
//    Console.WriteLine("Mensagem com for");
//}


//exemplo 1

//for (int i = 0; i < 4; i++)
//{
//    Console.Write("Nome: ");
//    string nome = Console.ReadLine();

//    Console.Write("Sobrenome: ");
//    string sobrenome = Console.ReadLine();

//    string nomeCompleto = nome + " " + sobrenome;
//    Console.WriteLine("Nome Completo: " + nomeCompleto + "\n");
//}

for (int hora = 0; hora <=23; hora++)
{
    for (int minuto = 0; minuto <= 59; minuto ++)
    {
        for(int segundo = 0; segundo <= 59; segundo ++)
        {
            Console.WriteLine(hora + ":" + minuto + ":" + segundo);
            Thread.Sleep(1000);
        }
    }
}


