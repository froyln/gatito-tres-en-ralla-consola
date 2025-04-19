using System;
using System.Runtime.CompilerServices;

public class Program
{
    static string[] xGrande =
        {
            "■   ■",
            "  ■  ",
            "■   ■"
        };

    static string[] oGrande =
        {
            "■ ■ ■",
            "■   ■",
            "■ ■ ■"
        };

    static string[] selectGrande =
        {
            "▄▄     ▄▄",
            "█       █",
            "█       █",
            "█       █",
            "▀▀     ▀▀"
        };

    static string[] turnoX =
    {
        @"████████ ██    ██ ██████  ███    ██  ██████         ██   ██ ",
        @"   ██    ██    ██ ██   ██ ████   ██ ██    ██ ██      ██ ██  ",
        @"   ██    ██    ██ ██████  ██ ██  ██ ██    ██          ███   ",
        @"   ██    ██    ██ ██   ██ ██  ██ ██ ██    ██ ██      ██ ██  ",
        @"   ██     ██████  ██   ██ ██   ████  ██████         ██   ██ "
    };

    static string[] turnoO =
    {
        @"████████ ██    ██ ██████  ███    ██  ██████          ██████ ",
        @"   ██    ██    ██ ██   ██ ████   ██ ██    ██ ██     ██    ██",
        @"   ██    ██    ██ ██████  ██ ██  ██ ██    ██        ██    ██",
        @"   ██    ██    ██ ██   ██ ██  ██ ██ ██    ██ ██     ██    ██",
        @"   ██     ██████  ██   ██ ██   ████  ██████          ██████ "
    };

    static string[] winX =
    {
        @" ██████   █████  ███    ██  █████  ██████   ██████  ██████         ██   ██ ",
        @"██       ██   ██ ████   ██ ██   ██ ██   ██ ██    ██ ██   ██ ██      ██ ██  ",
        @"██   ███ ███████ ██ ██  ██ ███████ ██   ██ ██    ██ ██████           ███   ",
        @"██    ██ ██   ██ ██  ██ ██ ██   ██ ██   ██ ██    ██ ██   ██ ██      ██ ██  ",
        @" ██████  ██   ██ ██   ████ ██   ██ ██████   ██████  ██   ██        ██   ██ "
    };

    static string[] winO =
    {
        @" ██████   █████  ███    ██  █████  ██████   ██████  ██████          ██████  ",
        @"██       ██   ██ ████   ██ ██   ██ ██   ██ ██    ██ ██   ██ ██     ██    ██ ",
        @"██   ███ ███████ ██ ██  ██ ███████ ██   ██ ██    ██ ██████         ██    ██ ",
        @"██    ██ ██   ██ ██  ██ ██ ██   ██ ██   ██ ██    ██ ██   ██ ██     ██    ██ ",
        @" ██████  ██   ██ ██   ████ ██   ██ ██████   ██████  ██   ██         ██████  "
    };

    static string[] empate =
    {
        @"███████ ███    ███ ██████   █████  ████████ ███████     ██  ",
        @"██      ████  ████ ██   ██ ██   ██    ██    ██          ██  ",
        @"█████   ██ ████ ██ ██████  ███████    ██    █████       ██  ",
        @"██      ██  ██  ██ ██      ██   ██    ██    ██              ",
        @"███████ ██      ██ ██      ██   ██    ██    ███████     ██  "
    };

    static string[] num3 =
    {
        @"██████  ",
        @"      ██",
        @" █████  ",
        @"      ██",
        @"██████  "
    };

    static string[] num2 =
    {
        @"██████  ",
        @"      ██",
        @" █████  ",
        @"██      ",
        @"███████ "
    };

    static string[] num1 =
    {
        @"   ██   ",
        @" ████   ",
        @"   ██   ",
        @"   ██   ",
        @" ▀▀▀▀▀▀ "
    };
    public static void Main() {

        while (true)
        {
            string[] tablero = {
            " ", " ", " ",
            " ", " ", " ",
            " ", " ", " "
        };

            int jugador = 1, jugadas = 0;
            bool finPartida = false;

            MenuNoOpciones(37, 15, Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = (ConsoleColor)4;
            for (int i = 0; i < turnoX.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 30, i);
                Console.Write(turnoX[i]);
            }

            while (!finPartida && jugadas < 9)
            {
                int posicion = MoverYSeleccionar(tablero, jugador);

                if (posicion != -1)
                {
                    if (jugador == 1)
                    {
                        tablero[posicion] = "X";
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = (ConsoleColor)4;
                        for (int i = 0; i < turnoO.Length; i++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 30, i);
                            Console.Write(turnoO[i]);
                        }
                    }
                    else
                    {
                        tablero[posicion] = "O";
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = (ConsoleColor)4;
                        for (int i = 0; i < turnoX.Length; i++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth / 2 - 30, i);
                            Console.Write(turnoX[i]);
                        }
                    }
                    jugadas++;

                    //Verificar signos para el tablero grande

                    if (VerificarGanador(tablero))
                    {
                        DibujarTablero(tablero);
                        if (jugador == 1)
                        {
                            Console.BackgroundColor = (ConsoleColor)4;
                            for (int i = 0; i < winX.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth / 2 - 36, i);
                                Console.Write(winX[i]);
                            }

                            System.Threading.Thread.Sleep(500);
                            for (int i = 0; i < num3.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                                Console.Write(num3[i]);
                            }
                            System.Threading.Thread.Sleep(1000);
                            for (int i = 0; i < num2.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                                Console.Write(num2[i]);
                            }
                            System.Threading.Thread.Sleep(1000);
                            for (int i = 0; i < num1.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                                Console.Write(num1[i]);
                            }
                            System.Threading.Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.BackgroundColor = (ConsoleColor)4;
                            for (int i = 0; i < winO.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth / 2 - 36, i);
                                Console.Write(winO[i]);
                            }
                            System.Threading.Thread.Sleep(500);
                            for (int i = 0; i < num3.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                                Console.Write(num3[i]);
                            }
                            System.Threading.Thread.Sleep(1000);
                            for (int i = 0; i < num2.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                                Console.Write(num2[i]);
                            }
                            System.Threading.Thread.Sleep(1000);
                            for (int i = 0; i < num1.Length; i++)
                            {
                                Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                                Console.Write(num1[i]);
                            }
                            System.Threading.Thread.Sleep(1000);
                        }
                        finPartida = true;
                    }
                    else if (jugadas == 9)
                    {
                        DibujarTablero(tablero);
                        Console.BackgroundColor = (ConsoleColor)4;
                        for (int i = 0; i < empate.Length; i++)
                        {
                            Console.SetCursorPosition(30, i);
                            Console.Write(empate[i]);
                        }

                        System.Threading.Thread.Sleep(500);
                        for (int i = 0; i < num3.Length; i++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                            Console.Write(num3[i]);
                        }
                        System.Threading.Thread.Sleep(1000);
                        for (int i = 0; i < num2.Length; i++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                            Console.Write(num2[i]);
                        }
                        System.Threading.Thread.Sleep(1000);
                        for (int i = 0; i < num1.Length; i++)
                        {
                            Console.SetCursorPosition(Console.WindowWidth - num3[1].Length - 1, Console.WindowHeight - num3.Length - 1 + i);
                            Console.Write(num1[i]);
                        }
                        System.Threading.Thread.Sleep(1000);
                        finPartida = true;
                    }
                    else
                    {
                        if (jugador == 1)
                        {
                            jugador = 2;
                        }
                        else
                        {
                            jugador = 1;
                        }
                    }
                }
            }
        }
        
    }

    static void DibujarTablero(string[] tablero, int cursor = -1) {
        //Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;

        for (int i = 0; i < 9; i++)
        {
            int x = (i % 3) * 4 + 5;
            int y = (i / 3) * 2 + 2;

            Console.SetCursorPosition(x, y);

            if (cursor == i)
            {
                Console.Write($"[{tablero[i]}]");
            }
            else
            {
                Console.Write($" {tablero[i]} ");
            }    

            // Dibujar las líneas verticales
            if (i % 3 != 2)
            {
                Console.Write("|");
            }
        }

        for (int i = 0; i < 9; i++)
        {
            int x1 = 0;
            int y = 0;
            switch (i)
            {
                case 0:
                    x1 = Console.WindowWidth/2 - 15;
                    y = Console.WindowHeight/2 - 7;
                    break;
                case 1:
                    x1 = Console.WindowWidth/2 - 3;
                    y = Console.WindowHeight/2 - 7;
                    break;
                case 2:
                    x1 = Console.WindowWidth/2 + 9;
                    y = Console.WindowHeight/2 - 7;
                    break;
                case 3:
                    x1 = Console.WindowWidth/2 - 15;
                    y = Console.WindowHeight/2 - 1;
                    break;
                case 4:
                    x1 = Console.WindowWidth/2 - 3;
                    y = Console.WindowHeight/2 - 1;
                    break;
                case 5:
                    x1 = Console.WindowWidth/2 + 9;
                    y = Console.WindowHeight/2 - 1;
                    break;
                case 6:
                    x1 = Console.WindowWidth/2 - 15;
                    y = Console.WindowHeight/2 + 5;
                    break;
                case 7:
                    x1 = Console.WindowWidth/2 - 3;
                    y = Console.WindowHeight/2 + 5;
                    break;
                case 8:
                    x1 = Console.WindowWidth/2 + 9;
                    y = Console.WindowHeight/2 + 5;
                    break;
            }

            if (cursor == i)
            {
                //Imprimir el [ ] grande de la casilla seleccionada
                for (int f = 0; f < selectGrande.Length; f++)
                {
                    Console.SetCursorPosition(x1 - 1, y - 1 + f);
                    Console.Write(selectGrande[f]);
                }
                //Imprimir el "X" o "O" grande 
                if (tablero[i] == "X")
                {
                    for (int f = 0; f < xGrande.Length; f++)
                    {
                        Console.SetCursorPosition(x1 + 1, y + f);
                        Console.Write(xGrande[f]);
                    }
                }
                else if (tablero[i] == "O")
                {
                    for (int f = 0; f < oGrande.Length; f++)
                    {
                        Console.SetCursorPosition(x1 + 1, y + f);
                        Console.Write(oGrande[f]);
                    }
                }
            }
            else
            {
                //Vaciamos el anterior select (si es que existe)
                for (int f = 0; f < selectGrande.Length; f++)
                {
                    Console.SetCursorPosition(x1 - 1, y - 1 + f);
                    Console.Write("         ");
                }
                //Imprimir el "X" o "O" grande 
                if (tablero[i] == "X")
                {
                    for (int f = 0; f < xGrande.Length; f++)
                    {
                        Console.SetCursorPosition(x1 + 1, y + f);
                        Console.Write(xGrande[f]);
                    }
                }
                else if (tablero[i] == "O")
                {
                    for (int f = 0; f < oGrande.Length; f++)
                    {
                        Console.SetCursorPosition(x1 + 1, y + f);
                        Console.Write(oGrande[f]);
                    }
                }
            }
        }

        // Dibujar las líneas horizontales
        for (int i = 1; i <= 2; i++)
        {
            Console.SetCursorPosition(5, i * 2 + 2 - 1);
            Console.WriteLine("---+---+---");
        }

        //Dibujar las lineas verticales grandes
        for (int i = 0; i < 18; i++)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 6, Console.WindowHeight / 2 - 8 + i);
            Console.WriteLine("|");
            Console.SetCursorPosition(Console.WindowWidth / 2 + 6, Console.WindowHeight / 2 - 8 + i);
            Console.WriteLine("|");
        }

        //Dibujar las lineas horizontales grandes
        for (int i = 0; i < 36; i++)
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - 17 + i, Console.WindowHeight / 2 - 3);
            Console.WriteLine("-");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 17 + i, Console.WindowHeight / 2 + 3);
            Console.WriteLine("-");
        }

        //Esquinas
        Console.SetCursorPosition(Console.WindowWidth / 2 - 6, Console.WindowHeight / 2 - 3);
        Console.Write("+");
        Console.SetCursorPosition(Console.WindowWidth / 2 + 6, Console.WindowHeight / 2 - 3);
        Console.Write("+");
        Console.SetCursorPosition(Console.WindowWidth / 2 - 6, Console.WindowHeight / 2 + 3);
        Console.Write("+");
        Console.SetCursorPosition(Console.WindowWidth / 2 + 6, Console.WindowHeight / 2 + 3);
        Console.Write("+");
    }

    static int MoverYSeleccionar(string[] tablero, int jugador) {
        int posicion = 0;
        ConsoleKeyInfo tecla;

        while (true)
        {
            DibujarTablero(tablero, posicion);

            tecla = Console.ReadKey(true);

            switch (tecla.Key)
            {
                case ConsoleKey.UpArrow:
                    if (posicion > 2) posicion -= 3;
                    break;
                case ConsoleKey.DownArrow:
                    if (posicion < 6) posicion += 3;
                    break;
                case ConsoleKey.LeftArrow:
                    if (posicion % 3 != 0) posicion -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    if (posicion % 3 != 2) posicion += 1;
                    break;
                case ConsoleKey.Enter:
                    if (tablero[posicion] == " ")
                        return posicion;
                    break;
            }
        }
    }

    static bool VerificarGanador(string[] tablero) {
        int[,] combinacionesGanadoras = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, // Filas
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, // Columnas
            { 0, 4, 8 }, { 2, 4, 6 }              // Diagonales
        };

        for (int i = 0; i < combinacionesGanadoras.GetLength(0); i++)
        {
            int a = combinacionesGanadoras[i, 0];
            int b = combinacionesGanadoras[i, 1];
            int c = combinacionesGanadoras[i, 2];

            if (tablero[a] != " " && tablero[a] == tablero[b] && tablero[a] == tablero[c])
            {
                return true;
            }
        }

        return false;
    }

    static void MenuBackground(int tamañoAncho, int tamañoLargo, int posicionXOriginal, int posicionYOriginal) {
        string titulo = "|| G A T I T O ||";
        //Fondo 
        Console.BackgroundColor = (ConsoleColor)4;
        Console.Clear();

        //Sombra del fondo del Menu del gato chiquito
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Black;
        for (int i = 0; i < 7; i++)
        {
            Console.SetCursorPosition(5, 2 + i);
            Console.WriteLine("             ");
        }
        

        //Fondo del gato chiquito
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.SetCursorPosition(4, 1);
        Console.Write("┌");
        Console.SetCursorPosition(5, 1);
        for (int i = 0; i < 11; i++)
            Console.Write("─");
        Console.Write("┐");
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(4, 2 + i);
            Console.Write("│           │");
        }
        Console.SetCursorPosition(4, 7);
        Console.Write("└");
        Console.SetCursorPosition(5, 7);
        for (int i = 0; i < 11; i++)
            Console.Write("─");
        Console.Write("┘");


        //Sombra del fondo del Menu
        Console.ForegroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Black;
        int posicionX = posicionXOriginal;
        int posicionY = posicionYOriginal - 3;
        int j = 0;
        for (int i = 0; i < tamañoLargo + 7; i++)
        {
            while (j < tamañoAncho + 3)
            {
                Console.SetCursorPosition(posicionX, posicionY);
                Console.Write(" ");
                posicionX++;
                j++;
            }
            posicionX = posicionXOriginal;
            j = 0;
            posicionY++;
        }

        //Fondo del Menu
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Black;
        posicionX = posicionXOriginal - 2;
        posicionY = posicionYOriginal - 4;
        j = 0;
        for (int i = 0; i < tamañoLargo + 6; i++)
        {
            while (j < tamañoAncho + 3)
            {
                Console.SetCursorPosition(posicionX, posicionY);
                Console.Write(" ");
                posicionX++;
                j++;
            }
            posicionX = posicionXOriginal - 2;
            j = 0;
            posicionY++;
        }

        //Bordes
        posicionX = posicionXOriginal - 2;
        posicionY = posicionYOriginal - 4;
        Console.SetCursorPosition(posicionX, posicionY);
        Console.Write("┌");
        posicionX++;
        for (int i = 0; i < tamañoAncho / 2 - titulo.Length / 2; i++)
        {
            Console.SetCursorPosition(posicionX, posicionY);
            Console.Write("─");
            posicionX++;
        }
        Console.SetCursorPosition(posicionX, posicionY);
        Console.Write("┤");
        posicionX++;
        Console.SetCursorPosition(posicionX, posicionY);
        Console.Write(titulo);
        posicionX += titulo.Length;
        Console.SetCursorPosition(posicionX, posicionY);
        Console.Write("├");
        posicionX++;
        for (int i = 0; i < tamañoAncho / 2 - titulo.Length / 2; i++)
        {
            Console.SetCursorPosition(posicionX, posicionY);
            Console.Write("─");
            posicionX++;
        }
        Console.SetCursorPosition(posicionX, posicionY);
        Console.Write("┐");
        posicionY++;
        for (int i = 0; i < tamañoLargo + 5; i++)
        {
            Console.SetCursorPosition(posicionX, posicionY);
            Console.Write("│");
            posicionY++;
        }
        Console.SetCursorPosition(posicionX, posicionY);
        Console.Write("┘");
        posicionX--;
        for (int i = 0; i < tamañoAncho + 2; i++)
        {
            Console.SetCursorPosition(posicionX, posicionY);
            Console.Write("─");
            posicionX--;
        }
        Console.SetCursorPosition(posicionX, posicionY);
        Console.Write("└");
        posicionY--;
        for (int i = 0; i < tamañoLargo + 5; i++)
        {
            Console.SetCursorPosition(posicionX, posicionY);
            Console.Write("│");
            posicionY--;
        }

        //posicionY += 2;
        //posicionX++;
        //Console.SetCursorPosition(posicionX, posicionY);
        //Console.Write("Utiliza las flechas para moverte...");
    }

    static void MenuNoOpciones(int tamañoAncho, int tamañoLargo, int posicionX, int posicionY) {
        Console.CursorVisible = false;

        //Hago que la posicion reste los caracteres de las opciones
        //para que se posicione correctamente y no inicie desde el centro
        posicionX = posicionX - tamañoAncho / 2;
        posicionY = posicionY - tamañoLargo / 2;

        //Personalizacion del menu
        MenuBackground(tamañoAncho, tamañoLargo, posicionX, posicionY);

        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.ResetColor();
    }
}

