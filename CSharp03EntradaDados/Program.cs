/*
Console.Write("Digite o nome do produto: ");
string nomeProduto = Console.ReadLine();

Console.Write("Digite a quantidade para compra: ");
int quantidade = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o preço unitario: ");
double precoUnitario = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Produto: " + nomeProduto);
Console.WriteLine("Quantodade: " + quantidade);
Console.WriteLine("Preço total: " + (precoUnitario * quantidade));

*/

//exercicio 2

Console.Write("Informe seu salario: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor da conta de internet: ");
double contaInternet = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor da conta de Energia: ");
double contaEnergia = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor da conta de Agua: ");
double contaAgua = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor da mensalidade da natação: ");
double mensalidadeNatacao = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor mensal do IPTU: ");
double valorMensalIPTU = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a quantidade de mensalidades do IPTU: ");
int quantidadeParcelasIPTU = Convert.ToInt32(Console.ReadLine());

double valorTotalContas = (contaAgua + contaEnergia + contaInternet);
double iptuTotal = valorMensalIPTU * quantidadeParcelasIPTU;

Console.WriteLine("\n\nValor total das contas: " + valorTotalContas);
Console.WriteLine("Total pago no IPTU: " + iptuTotal);
Console.WriteLine("Salario restante: " + (salario - (valorTotalContas + iptuTotal + mensalidadeNatacao)));
