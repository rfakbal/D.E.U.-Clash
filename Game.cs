
using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DEU_Lettters_Game {
public class Game
{
    public static int pos1Value, pos2Value, pos3Value, pos4Value, pos5Value,
            pos6Value, pos7Value, pos8Value, pos9Value,
            pos1Color, pos2Color, pos3Color, pos4Color, pos5Color, pos6Color, pos7Color, pos8Color, pos9Color;
    public static int userPoint, computerPoint, tablePoint;
        public static int easy, medium, hard;
    public static bool printSeq = true;
    public static bool deuOrdered;

    public static void printBoard()
    {
        Console.WriteLine("   1 2 3");
        Console.WriteLine(" +--------+");
        for (int i = 0; i < 3; i++)
        {
            Console.Write((i + 1) + "| ");
            for (int j = 0; j < 3; j++)
            {
                int posIndex = i * 3 + j;
                int value = 0, color = 0;
                switch (posIndex)
                {
                    case 0:
                        value = pos1Value;
                        color = pos1Color;
                        break;
                    case 1:
                        value = pos2Value;
                        color = pos2Color;
                        break;
                    case 2:
                        value = pos3Value;
                        color = pos3Color;
                        break;
                    case 3:
                        value = pos4Value;
                        color = pos4Color;
                        break;
                    case 4:
                        value = pos5Value;
                        color = pos5Color;
                        break;
                    case 5:
                        value = pos6Value;
                        color = pos6Color;
                        break;
                    case 6:
                        value = pos7Value;
                        color = pos7Color;
                        break;
                    case 7:
                        value = pos8Value;
                        color = pos8Color;
                        break;
                    case 8:
                        value = pos9Value;
                        color = pos9Color;
                        break;
                    default:
                        value = -1;
                        color = -1;
                        break;
                }


                string displayChar = "";
                if (value == 1)
                { // D
                    if (color == 1)
                    {
                        displayChar = "D "; // Red
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else if (color == 2)
                    {
                        displayChar = "D "; // Green
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                    else if (color == 3)
                    {
                        displayChar = "D "; // Blue
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                }
                else if (value == 2)
                { //E
                    if (color == 1)
                    {
                        displayChar = "E ";
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else if (color == 2)
                    {
                        displayChar = "E ";
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                    else if (color == 3)
                    {
                        displayChar = "E ";
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                }
                else if (value == 3)
                { //U
                    if (color == 1)
                    {
                        displayChar = "U ";
                        Console.ForegroundColor = ConsoleColor.Red;

                    }
                    else if (color == 2)
                    {
                        displayChar = "U ";
                        Console.ForegroundColor = ConsoleColor.Green;

                    }
                    else if (color == 3)
                    {
                        displayChar = "U ";
                        Console.ForegroundColor = ConsoleColor.Blue;

                    }
                }

                Console.Write(displayChar);

            }
            Console.ResetColor();
            Console.WriteLine(" |");
        }
        Console.WriteLine(" +--------+");
    }


    public static void getInput()
    {
        Console.WriteLine("Enter a Position to Edit (1-9):");
        int inputPos = Convert.ToInt32(Console.ReadLine()) - 1;

        Console.WriteLine("Enter The New Letter (1-D, 2-E, 3-U):");
        int inputValue = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter The New Color (1-Red, 2-Green, 3-Blue):");
        int inputColor = Convert.ToInt32(Console.ReadLine());

        switch (inputPos)
        {
            case 0:
                pos1Value = inputValue;
                pos1Color = inputColor;
                break;
            case 1:
                pos2Value = inputValue;
                pos2Color = inputColor;
                break;
            case 2:
                pos3Value = inputValue;
                pos3Color = inputColor;
                break;
            case 3:
                pos4Value = inputValue;
                pos4Color = inputColor;
                break;
            case 4:
                pos5Value = inputValue;
                pos5Color = inputColor;
                break;
            case 5:
                pos6Value = inputValue;
                pos6Color = inputColor;
                break;
            case 6:
                pos7Value = inputValue;
                pos7Color = inputColor;
                break;
            case 7:
                pos8Value = inputValue;
                pos8Color = inputColor;
                break;
            case 8:
                pos9Value = inputValue;
                pos9Color = inputColor;
                break;
            default:
                Console.WriteLine("Invalid position.");
                break;
        }
    }

    public static void printValue()
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write((j + 1) + "| ");
            for (int k = 0; k < 3; k++)
            {
                int posIndex = j * 3 + k;
                int value = 0, color = 0;
                switch (posIndex)
                {
                    case 0:
                        value = pos1Value;
                        color = pos1Color;
                        break;
                    case 1:
                        value = pos2Value;
                        color = pos2Color;
                        break;
                    case 2:
                        value = pos3Value;
                        color = pos3Color;
                        break;
                    case 3:
                        value = pos4Value;
                        color = pos4Color;
                        break;
                    case 4:
                        value = pos5Value;
                        color = pos5Color;
                        break;
                    case 5:
                        value = pos6Value;
                        color = pos6Color;
                        break;
                    case 6:
                        value = pos7Value;
                        color = pos7Color;
                        break;
                    case 7:
                        value = pos8Value;
                        color = pos8Color;
                        break;
                    case 8:
                        value = pos9Value;
                        color = pos9Color;
                        break;
                    default:
                        value = -1;
                        color = -1;
                        break;
                }

                string displayChar = "";
                if (value == 1)
                { // D
                    if (color == 1)
                    {
                        displayChar = "D ";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (color == 2)
                    {
                        displayChar = "D ";
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (color == 3)
                    {
                        displayChar = "D ";
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                }
                else if (value == 2)
                { // E
                    if (color == 1)
                    {
                        displayChar = "E ";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (color == 2)
                    {
                        displayChar = "E ";
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (color == 3)
                    {
                        displayChar = "E ";
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                }
                else if (value == 3)
                { // U
                    if (color == 1)
                    {
                        displayChar = "U ";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (color == 2)
                    {
                        displayChar = "U ";
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (color == 3)
                    {
                        displayChar = "U ";
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                }

                Console.Write(displayChar);
            }
            Console.ResetColor();
            Console.WriteLine(" |");
        }
    }

    public static void printRandom()
    {
        Random rand = new Random();

        pos1Value = rand.Next(3) + 1;
        pos1Color = rand.Next(3) + 1;

        pos2Value = rand.Next(3) + 1;
        pos2Color = rand.Next(3) + 1;

        pos3Value = rand.Next(3) + 1;
        pos3Color = rand.Next(3) + 1;

        pos4Value = rand.Next(3) + 1;
        pos4Color = rand.Next(3) + 1;

        pos5Value = rand.Next(3) + 1;
        pos5Color = rand.Next(3) + 1;

        pos6Value = rand.Next(3) + 1;
        pos6Color = rand.Next(3) + 1;

        pos7Value = rand.Next(3) + 1;
        pos7Color = rand.Next(3) + 1;

        pos8Value = rand.Next(3) + 1;
        pos8Color = rand.Next(3) + 1;

        pos9Value = rand.Next(3) + 1;
        pos9Color = rand.Next(3) + 1;
    }

        public static void Levels()
        {

        }

        public static void Main(string[] args)
    {
            Random rand = new Random();
            Console.WriteLine("Game Mode:");
            Console.WriteLine("");
            Console.WriteLine("1.Easy");
            Console.WriteLine("2.Moderate");
            Console.WriteLine("3.Hard");
            Console.WriteLine("");


            int value = 0;
            int gameMode = Convert.ToInt32(Console.ReadLine());
            switch (gameMode)
            {
                case 1:
                    value = easy;
                    Console.WriteLine("Enter game mode: Easy");
                    Console.WriteLine("");
                    Computer.computer();
                    break;
                case 2:
                    value = medium;
                    Console.WriteLine("Enter game mode: Medium");
                    Console.WriteLine("");
                    Computer.computer1();
                    break;
                case 3:
                    value = hard;
                    Console.WriteLine("Enter game mode: Hard");
                    Console.WriteLine("");
                    Computer.computer2();
                    break;
            }


            printRandom();

            for (int i = 0; i < 5; i++)
        {

                Console.WriteLine("Round " + (i + 1) + ": " + "User's Turn");
            Console.WriteLine("   1 2 3");
            Console.WriteLine(" +--------+");
            printValue();
            Console.WriteLine(" +--------+");
                Console.WriteLine("");
                getInput();
            Sequenses.CheckSequences();

            userPoint += tablePoint;
            tablePoint = 0;

            Console.WriteLine("   1 2 3");
            Console.WriteLine(" +--------+");
            printValue();
            Console.WriteLine(" +--------+");
                Console.WriteLine("");

                printRandom();
            Console.WriteLine("Shuffled Board:");
            Console.WriteLine("   1 2 3");
            Console.WriteLine(" +--------+");
            printValue();
            Console.WriteLine(" +--------+");
                Console.WriteLine("");
                Console.WriteLine("Round " + (i + 1) + ": " + "Computer's Turn");

                //Computer.computer2();
                Console.WriteLine("   1 2 3");
            Console.WriteLine(" +--------+");
            printValue();
            Console.WriteLine(" +--------+");
                Console.WriteLine("");
                Sequenses.CheckSequences();

                computerPoint += tablePoint;
            tablePoint = 0;
            printRandom();
        }

            if (userPoint > computerPoint)
        {
            Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Y       Y     OOOOO     U       U       W       W       I       N       N\r\n Y     Y    O       O   U       U       W       W       I       N N     N\r\n   Y Y     O         O  U       U       W   W   W       I       N   N   N\r\n    Y      O         O  U       U       W W   W W       I       N     N N\r\n    Y      O         O  U       U       W       W       I       N       N\r\n    Y       O       O    U     U        W       W       I       N       N\r\n    Y         OOOOO       UUUUU         W       W       I       N       N");
                Console.WriteLine("");
                Console.WriteLine(""); 
                Console.WriteLine("User's Point: " + userPoint);
            Console.WriteLine("Computer's Point: " + computerPoint);

            }
        else {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Y       Y     OOOOO     U       U       L           OOOOO      SSSSS     EEEEE\r\n Y     Y    O       O   U       U       L         O       O   S       S   E\r\n   Y Y     O         O  U       U       L        O           S           E\r\n    Y      O         O  U       U       L        O             SSSSS     EEEE\r\n    Y      O         O  U       U       L        O                   S   E\r\n    Y       O       O    U     U        L         O       O   S       S   E\r\n    Y         OOOOO       UUUUU         LLLLLLL     OOOOO      SSSSS     EEEEE\r\n");
                Console.WriteLine("");
                Console.WriteLine(""); 
                Console.WriteLine("User's Point: " + userPoint);
            Console.WriteLine("Computer's Point: " + computerPoint);
        }

    }
}
}




