using System;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TransformadorArchivo Tablero1 = new TransformadorArchivo("../../assets/board.txt");
            Logic jugada1 = new Logic();
            //jugada1.jugar(Tablero1)
            ImprimirTablero.imprimir(jugada1, Tablero1);
        }
    }
}
