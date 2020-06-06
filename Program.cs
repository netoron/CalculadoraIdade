using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meu nascimento é 20/10/2001");
            
            DateTime um = DateTime.Now;
            DateTime dois = new DateTime(2001, 10, 20);

            TimeSpan tres = um - dois;
            string tek = dois.ToShortDateString();

            int muitolouco = tres.Days;

            Console.WriteLine($"Eu Nasci em {tek} e ja vivi {muitolouco}dias");

        }
    }
}
