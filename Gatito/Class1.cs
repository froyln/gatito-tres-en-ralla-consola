/*using System;

public class Program
{
    public static void Main() {
        // JUEGO DEL GATO
        // 
        // Definicion de variables del juego
        int j1 = 0, j2 = 0, continuar = 0;
        int turno, movimientos, pos;
        string p1, p2, p3, p4, p5, p6, p7, p8, p9;
        string jugador1, jugador2, pieza;
        bool final;
        // Permite generar numeros aleatorios
        Random rd = new Random();
        // Obtenemos los nombres de los jugadores
        Console.Write("Nombre Jugador 1: ");
        jugador1 = Console.ReadLine();
        Console.Write("Nombre Jugador 2: ");
        jugador2 = Console.ReadLine();
        do
        {
            // Reinicializamos las variables para cada juego
            turno = 0;
            movimientos = 0;
            pos = 0;
            p1 = "1";
            p2 = "2";
            p3 = "3";
            p4 = "4";
            p5 = "5";
            p6 = "6";
            p7 = "7";
            p8 = "8";
            p9 = "9";
            pieza = "";
            final = false;
            // Definicion del turno
            turno = rd.Next(1, 2);
            // Este ciclo repite el juego hasta que llegue al final
            do
            {
                Console.Clear();
                if (turno == 1)
                {
                    Console.WriteLine("Turno para {0}", jugador1);
                    pieza = "X";
                    turno = 2;
                }
                else
                {
                    Console.WriteLine("Turno para {0}", jugador2);
                    pieza = "O";
                    turno = 1;
                }

                // Impresion del tablero
                Console.WriteLine(" ");
                Console.WriteLine(" {0} | {1} | {2}", p1, p2, p3);
                Console.WriteLine("───┼───┼───");
                Console.WriteLine(" {0} | {1} | {2}", p4, p5, p6);
                Console.WriteLine("───┼───┼───");
                Console.WriteLine(" {0} | {1} | {2}", p7, p8, p9);
                Console.WriteLine(" ");
            pedirposicion:

                // Obtener la posicion para colocar la ficha actual
                Console.Write("Seleccione una posición: ");
                pos = Convert.ToInt16(Console.ReadLine());

                // Determinar en que variable se va a colocar
                switch (pos)
                {
                    case 1:
                        if (p1 == "1")
                            p1 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 2:
                        if (p2 == "2")
                            p2 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 3:
                        if (p3 == "3")
                            p3 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 4:
                        if (p4 == "4")
                            p4 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 5:
                        if (p5 == "5")
                            p5 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 6:
                        if (p6 == "6")
                            p6 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 7:
                        if (p7 == "7")
                            p7 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 8:
                        if (p8 == "8")
                            p8 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    case 9:
                        if (p9 == "9")
                            p9 = pieza;
                        else
                            goto pedirposicion;
                        break;
                    default:
                        goto pedirposicion;
                }

                // Determinamos si hay un ganador despues del movimiento
                if (p1 == p2 && p2 == p3 && p3 == pieza) // Primera fila
                    final = true;
                else if (p4 == p5 && p5 == p6 && p6 == pieza) // Segunda fila
                    final = true;
                else if (p7 == p8 && p8 == p9 && p9 == pieza) // Tercera fila
                    final = true;

                if (p1 == p4 && p4 == p7 && p7 == pieza) // Primera columna
                    final = true;
                else if (p2 == p5 && p5 == p8 && p8 == pieza) // Segunda columna
                    final = true;
                else if (p3 == p6 && p6 == p9 && p9 == pieza) // Tercera columna
                    final = true;

                if (p1 == p5 && p5 == p9 && p9 == pieza) // Primera diagonal
                    final = true;
                else if (p3 == p5 && p5 == p7 && p7 == pieza) // Segunda diagonal
                    final = true;

                // Incrementamos el numero de movimientos (1-9)
                movimientos++;
            }
            while (final == false && movimientos < 9);

            // Verifica si hay ganador
            if (final == false)
                Console.WriteLine("No hay ganador");
            else if (pieza == "X")
            {
                Console.WriteLine("Ganador: {0}", jugador1);
                j1++;
            }
            else if (pieza == "O")
            {
                Console.WriteLine("Ganador: {0}", jugador2);
                j2++;
            }

            Console.WriteLine("Puntos de {0}: {1} pts", jugador1, j1);
            Console.WriteLine("Puntos de {0}: {1} pts", jugador2, j2);
            Console.Write("Desea jugar de nuevo: (0-No   1-Si)");
            continuar = Convert.ToInt16(Console.ReadLine());
        }
        while (continuar != 0);
    }
}*/