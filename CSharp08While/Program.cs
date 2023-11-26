/*

//-----exemplo 1--------------------------------------
int indice = 0, soma = 0;

while (indice < 5)
{
    Console.Write("\nInforme um numero: ");
    int numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
    indice++;
}
Console.WriteLine(soma);
*/


//-------------exemplo 2--------------------------------
/*
 *
int indice = 0, quantidadePessoasAdultas = 0, quantidadePessoasIdosas = 0, somaIdades = 0;

while (indice <=2)
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine().Trim();

    Console.Write("Idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    somaIdades += idade;

    if((idade >=18) && (idade < 60))
    {
        quantidadePessoasAdultas += 1;
    }
    else if((idade >= 60))
    {
        quantidadePessoasIdosas += 1;
    }
    indice++;
}

double mediaIdades = somaIdades / 3.0;

Console.WriteLine("Média das idades:" + mediaIdades + "\nQuantidade de pessoas adultas: " + quantidadePessoasAdultas + "\nQuantidade de pessoas idosas: " + quantidadePessoasIdosas);
*/
//----------------------------------------------------------------------------------------------------

//exercicio

/*  solicitar os seguintes dados de 5 pessoas
 *  - nome
 *  - idade
 *  - peso
 *  - altura
 *  Calcular o IMC: peso / altura²
 * 
 *
 *  Apresentar no final a quantidade de pessoas de acordo com o imc:
 *  - quantidade de pessoas abaixo do peso
 *  - quantidade de pessoas com peso normal
 *  - quantidade de pessoas excesso de peso
 *  - quantidade de pessoas obesidade I
 *  - quantidade de pessoas obesidade II
 *  - quantidade de pessoas obesidade III
 *  
 *      não esquecer de commitar a solução
 */


/*
int tam = 1;
int indice = 0;
int quantidadePessoasPesoAbaixo = 0;
int quantidadePessoasPesoNormal = 0;
int quantidadePessoasPesoExcesso = 0;
int quantidadePessoasObesidadeI = 0;
int quantidadePessoasObesidadeII = 0;
int quantidadePessoasObesidadeIII = 0;


pessoa[] pessoas = new pessoa[tam];


while(indice < tam)
{
    //Console.Write("\nInforme o nome da pessoa" + indice + 1 + ": ");
    //Console.WriteLine(pessoas[indice].nome);
    //Console.Write("\nInforme a idade da pessoa" + indice + 1 + ": ");
    //Console.WriteLine(pessoas[indice].idade);
    Console.Write("\nInforme o peso da pessoa" + indice + 1 + ": ");
    pessoas[indice] = new pessoa() {peso = Convert.ToDouble(Console.ReadLine())};
    Console.Write("\nInforme a altura da pessoa" + indice + 1 + ": ");
    pessoas[indice] = new pessoa() {altura = Convert.ToDouble(Console.ReadLine())};

    pessoas[indice].imc = pessoas[indice].calcularIMC(pessoas[indice].peso, pessoas[indice].altura);

    if(pessoas[indice].imc < 18.5)
    {
        quantidadePessoasPesoAbaixo += 1;
    }
    else if((pessoas[indice].imc >= 18.5) && (pessoas[indice].imc <= 24.99))
    {
        quantidadePessoasPesoNormal += 1;
    }
    else if ((pessoas[indice].imc >= 25) && (pessoas[indice].imc <= 29.99))
    {
        quantidadePessoasPesoExcesso += 1;
    }
    else if ((pessoas[indice].imc >= 30) && (pessoas[indice].imc <= 34.99))
    {
        quantidadePessoasObesidadeI += 1;
    }
    else if ((pessoas[indice].imc >= 35) && (pessoas[indice].imc <= 39.99))
    {
        quantidadePessoasObesidadeII += 1;
    }
    else if(pessoas[indice].imc >= 40)
    {
        quantidadePessoasObesidadeIII += 1;
    }

    indice++;
}

Console.Clear();
Console.WriteLine("Quantidade de pessoas abaixo do peso: " + quantidadePessoasPesoAbaixo);
Console.WriteLine("Quantidade de pessoas com peso normal: " + quantidadePessoasPesoNormal);
Console.WriteLine("Quantidade de pessoas com excesso de peso: " + quantidadePessoasPesoExcesso);
Console.WriteLine("Quantidade de pessoas com obesidade I: " + quantidadePessoasObesidadeI);
Console.WriteLine("Quantidade de pessoas com obesidade II: " + quantidadePessoasObesidadeII);
Console.WriteLine("Quantidade de pessoas com obesidade III " + quantidadePessoasObesidadeIII);



public class pessoa
{

    public string nome = "";
    public int idade = 0;
    public double peso = 0.0;
    public double altura = 0.0;
    public double imc = 0.0;

    public double calcularIMC(double peso, double altura)
    {
        return peso / Math.Pow(altura, 2);
    }
}

*/


int indice = 0;
double menorKmPorLitro = 999999;
int maiorQuantidadeKm = 0;
string modeloMenorKmPorLitro = "", modeloMaiorQuantidadeKm = "";

Console.Write("Informe a quantidade de carros que deseja validar: ");
int quantidadeDesejada = Convert.ToInt32(Console.ReadLine());

while (indice < quantidadeDesejada)
{

    Console.Write("Modelo: ");
    string modelo = Convert.ToString(Console.ReadLine().Trim());

    Console.Write("Quilometros rodados: ");
    int quantidadeKm = Convert.ToInt32(Console.ReadLine());

    Console.Write("Quilometros por litro: ");
    double kmPorLitro = Convert.ToDouble(Console.ReadLine());

    if(quantidadeKm > maiorQuantidadeKm)
    {
        maiorQuantidadeKm = quantidadeKm;
        modeloMaiorQuantidadeKm = modelo;
    }

    if(kmPorLitro < menorKmPorLitro)
    {
        menorKmPorLitro = kmPorLitro;
        modeloMenorKmPorLitro = modelo;
    }
    
    Console.WriteLine("\n");
    indice++;

}

Console.WriteLine("Menor consumo por Litro: " + modeloMenorKmPorLitro + ", " + menorKmPorLitro);
Console.WriteLine("Maior quilometragem rodada: " + modeloMaiorQuantidadeKm + ", " + maiorQuantidadeKm);





