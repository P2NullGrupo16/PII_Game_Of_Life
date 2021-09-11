using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        public static void imprimir(Logic jugada, bool[,] TableroA) 
        {
            bool[,] juego = jugada.Jugar(TableroA);
            while (true)
            {
            int width = juego.GetLength(0); //variabe que representa el ancho del tablero
            int height = juego.GetLength(1);//variabe que representa altura del tablero
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(juego[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            juego = jugada.Jugar(juego);
            Thread.Sleep(300);
            }
        }
    }
}