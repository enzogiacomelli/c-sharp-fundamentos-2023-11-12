/*
string[] nomes = new string[3];
int[] quantidades = new int[3];
double[] precosUnitarios = new double[3];


for (int i = 0; i < 3; i++)
{
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine().Trim();
    Console.Write("Quantidade: ");
    quantidades[i] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Preço Unitário: ");
    precosUnitarios[i] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("\n");
 }


double[] precoProdutos = new double[3];
double total = 0.0;

for(int i = 0; i < 3; i++)
{
    precoProdutos[i] = quantidades[i] * precosUnitarios[i];
    total += precoProdutos[i];
}

Console.WriteLine("\n\n Produto 1: " + precoProdutos[0]);
Console.WriteLine("\n\n Produto 2: " + precoProdutos[1]);
Console.WriteLine("\n\n Produto 3: " + precoProdutos[2]);
Console.WriteLine("\n\n Total: " + total);
*/

//exercicio
/*
 * nome, quantidade horas, valor hora, desconto unimed e odonto
 * 2 pessoas
 * apresentar salario bruto, liquido, soma dos descontos 
 * 
 */

int tam = 2;
string[] nomes = new string[tam];
int [] quantidadeHoras = new int[tam];
double[] valorHoras = new double[tam];
double[] descontoUnimed = new double[tam];
double[] descontoOdonto = new double[tam];


for (int i = 0; i < tam; i++)
{
    Console.Write("Nome: ");
    nomes[i] = Console.ReadLine();

    Console.Write("Quantidade de horas trabalhadas: ");
    quantidadeHoras[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Valor hora: ");
    valorHoras[i] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Desconto Unimed: ");
    descontoUnimed[i] = Convert.ToDouble(Console.ReadLine());

    Console.Write("Desconto Odonto: " + "\n");
    descontoOdonto[i] = Convert.ToDouble(Console.ReadLine());
}

Console.Clear();


double[] salarioBruto = new double[tam];
double[] salarioLiquido = new double[tam];
double[] somaDescontos = new double[tam];

for (int i = 0; i < tam; i++)
{
    salarioBruto[i] = quantidadeHoras[i] * valorHoras[i];
    somaDescontos[i] = descontoOdonto[i] + descontoUnimed[i];
    salarioLiquido[i] = salarioBruto[i] - somaDescontos[i];
}


for (int i = 0; i < tam; i++)
{
    Console.WriteLine("Nome: " + nomes[i]);
    Console.WriteLine("Salario bruto:" + salarioBruto[i] + "\n Salario Liquido: " + salarioLiquido[i]);
    Console.WriteLine("Total dos descontos: " + somaDescontos[i] + "\n");
}
