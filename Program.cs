// usa o System, que tem as principais classes usadas
using System;
//cria a classe Programa
class Programa
{
    //cria um principal para começar o programa
    static void Main()
    {
        //cria uma variável inteira com o valor inicial 0
        int num = 0;

        //faz o que tiver dentre {}
        do
        {
    
            //fala para o user
            Console.WriteLine("Digite um número de 1 à 10: ");
            //coloca a resposta do user como valor da variável num
            num = int.Parse(Console.ReadLine());


        }
        //enquanto a variável num for maior que 1 e menor que 10
        while (num < 1 || num > 10);


        //fala isso para o user após ele digitar o valor 
        Console.WriteLine("Você digitou o número " + num + ".");


    }

}
