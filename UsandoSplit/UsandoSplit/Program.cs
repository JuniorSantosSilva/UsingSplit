using System;

namespace UsandoSplit
{
internal class Program {

        static void Main(string[] args) {


            Console.WriteLine("Digite 3 cores: ");


            string s = Console.ReadLine();

            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }


    }
}