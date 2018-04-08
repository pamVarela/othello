using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Othello
{
    class Program
    {
        private static int[,] tablero;


        /// <summary>
        /// Función que va a rellena la matriz lógica con el tamaño de tablero elegido por el usuario.
        /// Utiliza los números 1 = blanco, 0 = negro, 2 = espacio vacío
        /// </summary>
        /// <param name="tamTablero"></param>
        /// <returns></returns>
        
        public static void RellenarTablero(int tamTablero)
        {
            tablero=new int[tamTablero,tamTablero];
            /*tablero = new int[8, 8]{{   2,2,2,2,2,2,2 },
                                    { 2,2,1,2,2,2,2,2 },
                                    { 2,2,1,2,2,2,2,2 },
                                    { 2,2,1,0,2,2,2,2 },
                                    { 2,2,0,1,2,2,2,2 },
                                    { 2,2,2,2,2,2,2,2 },
                                    { 2,2,2,2,2,2,2,2 },
                                    { 2,2,2,2,2,2,2,2 }};
             */
            for (int i=0; i<tamTablero; i++){
                for (int j=0; j<tamTablero; j++){
                    tablero[i,j]=2;
                }
            }
            int centro=tamTablero/2;
            tablero[centro-1,centro-1]=1;
            tablero[centro-1,centro]=0;
            tablero[centro,centro]=1;
            tablero[centro,centro-1]=0;
        }
            
        

        /// <summary>
        /// Función que imprime los valores de la matriz
        /// </summary>
        /// <param name="tablero"></param>
        /// <returns></returns>
        /// 
        public static void Imprimir(int[,] tablero ) {

            for (int x = 0; x < tablero.GetLength(0); x++)
            {
                for (int y = 0; y < tablero.GetLength(1); y++)
                {
                    Console.Write("\t"+tablero[x, y]);
                }
                Console.WriteLine();
            }
        }
    
        

        static void Main(string[] args)
        {
            int tipo=0;
            int tamTablero = 8;
            int opt=2;
            RellenarTablero(tamTablero);
            Imprimir(tablero);
            Console.ReadKey();
            Fichas tableroJugada = new Fichas(tablero, tamTablero);
            
            //MENU
            
            //opcion 1 computadora
            if(opt==1){
                for(int i=0; i<tamTablero;i++){
                    for(int j=0;j<tamTablero;j++){
                            if(tipo==tablero[i,j]){
                                Fichas.Comprobacion(i, j,tipo, tamTablero,0);            
                        }
                    }
                }
            }

            //opcion 2 jugador
            else if(opt==2){
            Console.WriteLine("  ");
                tablero[5,4]=0;
                Fichas.Comprobacion(5, 4, 0,tamTablero, 3); 
            }
            
            Imprimir(tablero);
            Console.ReadKey();

        }
    }
}
