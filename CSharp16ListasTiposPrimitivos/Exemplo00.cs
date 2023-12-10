namespace CSharp16ListasTiposPrimitivos
{
    internal class Exemplo00
    {
        public void Executar()
        {

            //LISTAS
            /*
            *
            *usam tipos primitivos
            *dinamicas
            *
            *
            */

            List<int> numeros = new List<int>();

            //adicionando numeros ao fim da lista
            numeros.Add(3);
            numeros.Add(1);
            numeros.Add(4);
            numeros.Add(3);
            numeros.Add(9);
            numeros.Add(99);

            //removendo valores
            //numeros.Remove(4); // removeu o numero 4 que estava na posicao de indice 2 dentro da lista


            //verifica se um valor esta na lista
            bool numero10ExisteNaLista = numeros.Contains(10);


            //alterando um valor de alguma posicao
            numeros[0] = 6; //mudando o valor da posição zero de 3 para 6

            //somando os valores da lista
            int soma = numeros[0] + numeros[1] + numeros[2] + numeros[3] + numeros[4] + numeros[5];
            Console.WriteLine(soma);
        }
    }
}
