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
        /// <param opt="opcion 0(recorrido) o 1(contar)"></param>
        /// <returns></returns>
        
        static int cantG=0;
        public static int posXG;
        public static int posYG;
        public static int[,] Comprobacion(int x, int y,int color, int tamTablero,int opt) { 
            int cantidad=0;
           
            if ((x != 0) && (tablero[x, y] != tablero[x - 1, y] ) ){ //1    
                if(opt==0){
                    if(tablero[x - 1, y]!=2){

                        Recorrido(x, y, tablero[x, y], -1, 0,tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, -1, 0,tamTablero,opt);
                }
            }   

            if ((y != tamTablero - 1)&&(x!=0) && (tablero[x, y] != tablero[x - 1, y + 1]) )//2
            {
                if(opt==0){
                    if(tablero[x - 1, y + 1] != 2 ){
                        Recorrido(x, y, tablero[x, y], -1, 1, tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, -1, 1,tamTablero,opt);
                }
                
            }
            if ((y != tamTablero - 1) && (tablero[x, y] != tablero[x, y + 1]))//3
            {  
                if(opt==0){
                    if(tablero[x, y + 1] != 2){
                        Recorrido(x, y, tablero[x, y], 0, 1, tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, 0, 1,tamTablero,opt);
                }

            }
            if ((y != tamTablero - 1) && (x!=tamTablero-1) && (tablero[x, y] != tablero[x + 1, y + 1]))//4
            {   
                if(opt==0){
                    if(tablero[x + 1, y + 1] != 2){
                        Recorrido(x, y, tablero[x, y], 1, 1, tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, 1, 1,tamTablero,opt);
                }

            }
            if ((x != tamTablero - 1) && (tablero[x, y] != tablero[x + 1, y]) )//5
            {   
                if(opt==0){
                    if(tablero[x + 1, y] != 2){
                        Recorrido(x, y, tablero[x, y], 1, 0, tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, 1, 0,tamTablero,opt);
                }
            }
            if ((x != tamTablero-1)&&( y!=0) && (tablero[x, y] != tablero[x + 1, y - 1]))//6
            {
                if(opt==0){
                    if(tablero[x + 1, y - 1] != 2){
                        Recorrido(x, y, tablero[x, y], 1, -1, tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, 1, -1,tamTablero,opt);
                }
            }
            if ((y != 0) && (tablero[x, y] != tablero[x, y - 1]))//7
            {   
                if(opt==0){
                    if(tablero[x, y - 1] != 2){
                        Recorrido(x, y, tablero[x, y],0, -1, tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, 0,-1,tamTablero,opt);
                }
            }
            if ((x != 0)&&(y!=0) && (tablero[x, y] != tablero[x -1, y - 1]))//8
            {   
                if(opt==0){
                    if(tablero[x -1, y - 1] != 2 ){
                        Recorrido(x, y, tablero[x, y], -1, -1, tamTablero,opt);
                    }
                }
                else{
                    cantidad=cantidad+Recorrido(x, y, color, -1, -1,tamTablero,opt);
                }

            }
            //Console.WriteLine(cantidad + "Cantidad"+opt);
            
            if (cantG<cantidad & opt==1){
                Console.WriteLine(x+" x , y "+y);
                Console.WriteLine(tablero[x,y]);
                tablero[x,y]=3;
                cantG=cantidad;
                posXG=x;
                posYG=y;
                //esto se debe guardar para enviarlo como mejor jugada despu'es de revisar todas
                
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

        public static int Recorrido(int x, int y, int color, int sumaX, int sumaY, int t,int opt) {  
                                                                                      
            int i = x + sumaX;                                                        
            int j = y + sumaY;                                                        
            int cantidad = 0;                                                         
            if(opt==0)
            {
                while (tablero[i,j] != color)
                {

                    if (tablero[i, j] == 2)
                    {
                        //manda a comprobar la posicion [i,j]
                        //necesito guardar la posicion para cambiar si es buena.
                        
                        Comprobacion(i, j,color, t,opt+1);
                        //cambiarFichas(x, y, i, j, color, sumaX, sumaY);
                        return 0;
                    }
                    else {
                        i = i + sumaX;
                        j = j + sumaY;
                    }
                }
                return 0;
            }
            else{
                
                Console.WriteLine(tablero[i, j]+" Hola "+ cantidad+ " color "+ color);
                while (tablero[i,j] != 2)
                {
                    Console.WriteLine(tablero[i, j]+"NA");
                    if (tablero[i, j] == color)
                    {
                        Console.WriteLine("Hola"+ cantidad);
                        return cantidad;
                        
                    }
                    else {
                        i = i + sumaX;
                        j = j + sumaY;
                        cantidad++;
                    }
                }
                return 0;
            }

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

        public static void cambiarFichas(int x, int  y,int color, int sumaX, int sumaY) {
            
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
