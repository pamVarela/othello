using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Othello
{
    class Fichas
    {
        public static int[,] tablero;


        public Fichas(int[,] tableroJugada, int tamTablero)
        {
            tablero = tableroJugada;
        }

        /// <summary>
        /// Función encargada de obtener las posiciones para comprobar si es necesario cambiar las fichas de color, recibe las posiciones                         
        /// que va a validar y el tamaño del tablero
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="tamTablero"></param>
        /// <returns></returns>
        

        public static int[,] Comprobacion(int x, int y, int tamTablero) { 
                                                                          
            if ((x != 0) && (tablero[x, y] != tablero[x - 1, y] )){ //1    
                Recorrido(x, y, tablero[x, y], -1, 0);
            }   
            if ((y != tamTablero - 1)&&(x!=0) && (tablero[x, y] != tablero[x - 1, y + 1]) )//2
            {
                Recorrido(x, y, tablero[x, y], -1, 1);
            }
            if ((y != tamTablero - 1) && (tablero[x, y] != tablero[x, y + 1]))//3
            {  
                Recorrido(x, y, tablero[x, y], 0, 1);
            }
            if ((y != tamTablero - 1) && (x!=tamTablero-1) && (tablero[x, y] != tablero[x + 1, y + 1]))//4
            {   
                Recorrido(x, y, tablero[x, y], 1, 1);
            }
            if ((x != tamTablero - 1) && (tablero[x, y] != tablero[x + 1, y]) )//5
            {   
                Recorrido(x, y, tablero[x, y], 1, 0);
            }
            if ((x != tamTablero-1)&&( y!=0) && (tablero[x, y] != tablero[x + 1, y - 1]))//6
            {   
                Recorrido(x, y, tablero[x, y], +1, -1);
            }
            if ((y != 0) && (tablero[x, y] != tablero[x, y - 1]))//7
            {   
                Recorrido(x, y, tablero[x, y], 0, -1);
            }
            if ((x != 0)&&(y!=0) && (tablero[x, y] != tablero[x -1, y - 1]))//8
            {   
                Recorrido(x, y, tablero[x, y], -1, -1);
            }
            return tablero;
        }


        /// <summary>
        /// Función encargada de revisar si la dirección que recibe tiene la posibilidad de cambiar las fichas. Recibe las posiciones de la matriz, el color al que debe cambiar  
        /// y sumaX, sumaY que significan la dirección en que se debe mover en la matriz                                                               
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        /// <param name="tamTablero"></param>
        /// <returns></returns>

        public static void Recorrido(int x, int y, int color, int sumaX, int sumaY) {  
                                                                                      
            int i = x + sumaX;                                                        
            int j = y + sumaY;                                                        
            int cantidad = 0;                                                         

            while (tablero[i,j] != 2)
            {
                if (tablero[i, j] == color)
                {
                    cambiarFichas(x, y, i, j, color, sumaX, sumaY);
                    break;
                }
                else {
                    i = i + sumaX;
                    j = j + sumaY;
                    cantidad++;
                }
            }
            //Console.ReadKey();
        }


        /// <summary>
        /// Función que se encarga de cambiar el color de la fichas a nivel lógico 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="color"></param>
        /// <param name="tamTablero"></param>
        /// <returns></returns>

        public static void cambiarFichas(int x, int  y, int i, int j, int color, int sumaX, int sumaY) {
            
            x = x + sumaX;
            y = y + sumaY;

            while (tablero[x,y]!=color) {
                tablero[x, y] = color;
                x = x + sumaX;
                y = y + sumaY;
            }
        }
    }
}
