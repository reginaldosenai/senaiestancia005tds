using AdvocaciaPrincipal.Modelo;
using System;

namespace AdvocaciaPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Advogado ad = new Advogado();
            ad.Idade = 20;

            Console.WriteLine(ad.Idade);

        }
    }
}
