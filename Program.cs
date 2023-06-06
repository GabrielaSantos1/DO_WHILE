using System;
class Programa
{
    static void Main()
    {
        int num = 0;

        do
        {

            Console.WriteLine("Digite um número de 1 à 10: ");
            num = int.Parse(Console.ReadLine());


        }
        while (num < 1 || num > 10);



        Console.WriteLine("Você digitou o número " + num + ".");


    }

}