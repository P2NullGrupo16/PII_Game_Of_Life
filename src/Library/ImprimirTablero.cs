using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    public class ImprimirTablero
    {
        public static void imprimir(Logic juego, TransformadorArchivo TableroA)
        {
            //bool[,] b //variable que representa el tablero
            int width = 20; //variabe que representa el ancho del tablero
            int height = 20;//variabe que representa altura del tablero
            while (true)
            {
            bool[,] jue = juego.jugar(TableroA);
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++)
            {
                for (int x = 0; x<width; x++)
                {
                    if(jue[x,y])
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
            //juego = juego.jugar(Tablero.Tablero);
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
            }
        }
    }
}