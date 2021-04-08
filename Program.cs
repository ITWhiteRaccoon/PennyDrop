using System;

namespace PennyDrop
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new PennyDrop();
            teste.A2.Switch();
            Console.WriteLine(teste.IsWinner(PennyDrop.Input.Y));
        }
    }
}
