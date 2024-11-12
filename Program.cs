using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{



    public static void Main(string[] args)
    {
        int pos1Value, pos2Value, pos3Value, pos4Value, pos5Value,// for each position (1-9) 
            pos6Value, pos7Value, pos8Value, pos9Value, pos1Color, // there exist 2 variables its color(RGB) 
            pos2Color, pos3Color, pos4Color, pos5Color, pos6Color, // and its letter value (DEU)
            pos7Color, pos8Color, pos9Color;  // user and computer points stored in userPoint, computerPoint

        int userPoint = 0; // user and computer points stored in userPoint, computerPoint
        int computerPoint = 0;
        int tablePoint = 0;  // table point refers to the point that current board holds
        bool printSeq = true;// setting for default
        bool deuOrdered; // used in sequence checking, stated that if the row other column has deu letters ordered
        int tempValue = 0;
        int tempColor = 0;
        int tempPosition = 0;
        // Creating temp values
        int originalValue = 0;
        int originalColor = 0;
        int computerMode = 0;
        Random rand = new Random();
        Console.WriteLine("Game Mode:");
        Console.WriteLine("");
        Console.WriteLine("1.Easy");
        Console.WriteLine("2.Moderate");
        Console.WriteLine("3.Hard");
        Console.WriteLine("");

        int difInput = Convert.ToInt32(Console.ReadLine());

        if (difInput == 1)
        {
            computerMode = 25;
        }
        else if (difInput == 2)
        {
            computerMode = 50;
        }
        else if (difInput == 3)
        {
            computerMode = 100;
        }
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

        for (int i = -1; i < 10; i++)
        {
            if (i == (-1))
            {
                Console.WriteLine();
                Console.WriteLine("###############" + " Initial Board " + "###############");
                Console.WriteLine();
            }
            if (i%2==0 && i!=-1)
            {
                Console.WriteLine();
                Console.WriteLine("###############"+ " Round: " + ((i / 2) + 1) + " User's Turn "+"###############");
                Console.WriteLine();
            }
            if(i%2!=0 && i != -1)
            {
                Console.WriteLine();
                Console.WriteLine("###############" + " Round: " + ((i / 2) + 1) + " Computer's Turn " + "###############");
                Console.WriteLine();
            }
            Console.WriteLine("   1 2 3");
            Console.WriteLine(" +--------+");
            for (int j = 0; j < 3; j++)
            {
                Console.Write((j + 1) + "| ");
                for (int k = 0; k < 3; k++)
                {
                    int posIndex = j * 3 + k;
                    int value, color = 0;
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
            Console.WriteLine(" +--------+");
            Console.WriteLine();
            int maxPoint = 0, maxPosition = -1, maxColor = 0, maxValue = 0;
            int secLoop = 0;
            for (; secLoop < computerMode+1; secLoop++)
            {
                if (i % 2 == 0)
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
                    Console.WriteLine("   1 2 3");
                    Console.WriteLine(" +--------+");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write((j + 1) + "| ");
                        for (int k = 0; k < 3; k++)
                        {
                            int posIndex = j * 3 + k;
                            int value, color = 0;
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
                    Console.WriteLine(" +--------+");
                    Console.WriteLine();
                }
                if (secLoop == computerMode)
                {
                    string displayChar2 = "";
                    Console.Write("Computer Changed: ");
                    if (maxValue == 1)
                    {
                        if (maxColor == 1)
                        {
                            displayChar2 = "Position: " + (maxPosition + 1) + " Letter: D ";
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (maxColor == 2)
                        {
                            displayChar2 = "Position: "+ (maxPosition + 1) + " Letter: D ";
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (maxColor == 3)
                        {
                            displayChar2 = "Position: " + (maxPosition + 1) + " Letter: D ";
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                    else if (maxValue == 2)
                    {
                        if (maxColor == 1)
                        {
                            displayChar2 = "Position: " + (maxPosition + 1) + " Letter: E ";
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (maxColor == 2)
                        {
                            displayChar2 = "Position: " + (maxPosition+1) + " Letter: E ";
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (maxColor == 3)
                        {
                            displayChar2 = "Position: " + (maxPosition+1) + " Letter: E ";
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                    else if (maxValue == 3)
                    {
                        if (maxColor == 1)
                        {
                            displayChar2 = "Position: " + (maxPosition+1) + " Letter: U ";
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (maxColor == 2)
                        {
                            displayChar2 = "Position: " + (maxPosition+1) + " Letter: U ";
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (maxColor == 3)
                        {
                            displayChar2 = "Position: " + (maxPosition+1) + " Letter: U ";
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                    }
                    Console.WriteLine(displayChar2);
                    Console.ResetColor();
                    // updating the best scenario
                    if (maxPosition != -1)
                    {
                        switch (maxPosition)
                        {
                            case 0:
                                //Console.WriteLine(1);
                                pos1Value = maxValue;
                                pos1Color = maxColor;
                                break;
                            case 1:
                                //Console.WriteLine(2);
                                pos2Value = maxValue;
                                pos2Color = maxColor;
                                break;
                            case 2:
                                //Console.WriteLine(3);
                                pos3Value = maxValue;
                                pos3Color = maxColor;
                                break;
                            case 3:
                                //Console.WriteLine(4);
                                pos4Value = maxValue;
                                pos4Color = maxColor;
                                break;
                            case 4:
                                //Console.WriteLine(5);
                                pos5Value = maxValue;
                                pos5Color = maxColor;
                                break;
                            case 5:
                                //Console.WriteLine(6);
                                pos6Value = maxValue;
                                pos6Color = maxColor;
                                break;
                            case 6:
                                //Console.WriteLine(7);
                                pos7Value = maxValue;
                                pos7Color = maxColor;
                                break;
                            case 7:
                                //Console.WriteLine(8);
                                pos8Value = maxValue;
                                pos8Color = maxColor;
                                break;
                            case 8:
                                //Console.WriteLine(9);
                                pos9Value = maxValue;
                                pos9Color = maxColor;
                                break;
                        }
                    }
                    Console.WriteLine("   1 2 3");
                    Console.WriteLine(" +--------+");
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write((j + 1) + "| ");
                        for (int k = 0; k < 3; k++)
                        {
                            int posIndex = j * 3 + k;
                            int value, color = 0;
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
                    Console.WriteLine(" +--------+");
                    Console.WriteLine();
                    printSeq = true;
                }
                if (i == -1)
                {
                    printSeq = true;
                    secLoop = computerMode+1;
                }

                if (i % 2 != 0 && secLoop < computerMode+1 && i != -1)
                {
                    // Code block of the Computer move
                    Random rd = new Random();
                    printSeq = false;
                    // Assigning random values
                    tempValue = rd.Next(3) + 1;
                    tempColor = rd.Next(3) + 1;
                    tempPosition = rd.Next(9);
                    // Creating temp values
                    originalValue = 0;
                    originalColor = 0;

                    switch (tempPosition)
                    {
                        case 0:
                            //Console.WriteLine(1);
                            originalValue = pos1Value;
                            originalColor = pos1Color;
                            pos1Value = tempValue;
                            pos1Color = tempColor;
                            break;
                        case 1:
                            //Console.WriteLine(2);
                            originalValue = pos2Value;
                            originalColor = pos2Color;
                            pos2Value = tempValue;
                            pos2Color = tempColor;
                            break;
                        case 2:
                            //Console.WriteLine(3);
                            originalValue = pos3Value;
                            originalColor = pos3Color;
                            pos3Value = tempValue;
                            pos3Color = tempColor;
                            break;
                        case 3:
                            //Console.WriteLine(4);
                            originalValue = pos4Value;
                            originalColor = pos4Color;
                            pos4Value = tempValue;
                            pos4Color = tempColor;
                            break;
                        case 4:
                            //Console.WriteLine(5);
                            originalValue = pos5Value;
                            originalColor = pos5Color;
                            pos5Value = tempValue;
                            pos5Color = tempColor;
                            break;
                        case 5:
                            //Console.WriteLine(6);
                            originalValue = pos6Value;
                            originalColor = pos6Color;
                            pos6Value = tempValue;
                            pos6Color = tempColor;
                            break;
                        case 6:
                            //Console.WriteLine(7);
                            originalValue = pos7Value;
                            originalColor = pos7Color;
                            pos7Value = tempValue;
                            pos7Color = tempColor;
                            break;
                        case 7:
                            //Console.WriteLine(8);
                            originalValue = pos8Value;
                            originalColor = pos8Color;
                            pos8Value = tempValue;
                            pos8Color = tempColor;
                            break;
                        case 8:
                            //Console.WriteLine(9);
                            originalValue = pos9Value;
                            originalColor = pos9Color;
                            pos9Value = tempValue;
                            pos9Color = tempColor;
                            break;
                    }
                }
                // Determining point by checking sequences
                if (secLoop == computerMode)
                {
                    printSeq = true;
                }
                //Checking Sequence 1 
                if ((pos1Value == 1 && pos2Value == 2 && pos3Value == 3 && (pos1Color == pos2Color && pos2Color == pos3Color))
                        || (pos1Value == 3 && pos2Value == 2 && pos3Value == 1
                                && (pos1Color == pos2Color && pos2Color == pos3Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.1 120 Points");
                    tablePoint += 120;
                }
                if ((pos4Value == 1 && pos5Value == 2 && pos6Value == 3 && (pos4Color == pos5Color && pos5Color == pos6Color))
                        || (pos4Value == 3 && pos5Value == 2 && pos6Value == 1
                                && (pos4Color == pos5Color && pos5Color == pos6Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.1 120 Points");
                    tablePoint += 120;
                }
                if ((pos7Value == 1 && pos8Value == 2 && pos9Value == 3 && (pos7Color == pos8Color && pos8Color == pos9Color))
                        || (pos7Value == 3 && pos8Value == 2 && pos9Value == 1
                                && (pos7Color == pos8Color && pos8Color == pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.1 120 Points");
                    tablePoint += 120;
                }

                if ((pos1Value == 1 && pos5Value == 2 && pos9Value == 3 && (pos1Color == pos5Color && pos5Color == pos9Color))
                        || (pos1Value == 3 && pos5Value == 2 && pos9Value == 1
                                && (pos1Color == pos5Color && pos5Color == pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.1 120 Points");
                    tablePoint += 120;
                }

                if ((pos3Value == 1 && pos5Value == 2 && pos7Value == 3 && (pos3Color == pos5Color && pos5Color == pos7Color))
                        || (pos3Value == 3 && pos5Value == 2 && pos7Value == 1
                                && (pos3Color == pos5Color && pos5Color == pos7Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.1 120 Points");
                    tablePoint += 120;
                }
                if ((pos1Value == 1 && pos4Value == 2 && pos7Value == 3 && (pos1Color == pos4Color && pos4Color == pos7Color))
                        || (pos1Value == 3 && pos4Value == 2 && pos7Value == 1
                                && (pos1Color == pos4Color && pos4Color == pos7Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.1 120 Points");
                    tablePoint += 120;
                }
                if ((pos2Value == 1 && pos5Value == 2 && pos8Value == 3 && (pos2Color == pos5Color && pos5Color == pos8Color))
                        || (pos2Value == 3 && pos5Value == 2 && pos8Value == 1
                                && (pos2Color == pos5Color && pos5Color == pos8Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.1 120 Points");
                    tablePoint += 120;
                }
                if ((pos3Value == 1 && pos6Value == 2 && pos9Value == 3 && (pos3Color == pos6Color && pos6Color == pos9Color))
                        || (pos3Value == 3 && pos6Value == 2 && pos9Value == 1
                                && (pos3Color == pos6Color && pos6Color == pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.1 120 Points");
                    tablePoint += 120;
                }
                //Checking sequence 2 
                if ((pos1Value == 1 && pos2Value == 2 && pos3Value == 3
                        && (pos1Color != pos2Color && pos2Color != pos3Color && pos1Color != pos3Color))
                        || (pos1Value == 3 && pos2Value == 2 && pos3Value == 1
                                && (pos1Color != pos2Color && pos2Color != pos3Color && pos1Color != pos3Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.2 - 110 Points");
                    tablePoint += 110;
                }
                if ((pos4Value == 1 && pos5Value == 2 && pos6Value == 3
                        && (pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color))
                        || (pos4Value == 3 && pos5Value == 2 && pos6Value == 1
                                && (pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.2 - 110 Points");
                    tablePoint += 110;
                }
                if ((pos7Value == 1 && pos8Value == 2 && pos9Value == 3
                        && (pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color))
                        || (pos7Value == 3 && pos8Value == 2 && pos9Value == 1
                                && (pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.2 - 110 Points");
                    tablePoint += 110;
                }

                if ((pos1Value == 1 && pos5Value == 2 && pos9Value == 3
                        && (pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color))
                        || (pos1Value == 3 && pos5Value == 2 && pos9Value == 1
                                && (pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.2 - 110 Points");
                    tablePoint += 110;
                }

                if ((pos3Value == 1 && pos5Value == 2 && pos7Value == 3
                        && (pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color))
                        || (pos3Value == 3 && pos5Value == 2 && pos7Value == 1
                                && (pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.2 - 110 Points");
                    tablePoint += 110;
                }
                if ((pos1Value == 1 && pos4Value == 2 && pos7Value == 3
                        && (pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color))
                        || (pos1Value == 3 && pos4Value == 2 && pos7Value == 1
                                && (pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.2 - 110 Points");
                    tablePoint += 110;
                }
                if ((pos2Value == 1 && pos5Value == 2 && pos8Value == 3
                        && (pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color))
                        || (pos2Value == 3 && pos5Value == 2 && pos8Value == 1
                                && (pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.2 - 110 Points");
                    tablePoint += 110;
                }
                if ((pos3Value == 1 && pos6Value == 2 && pos9Value == 3
                        && (pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color))
                        || (pos3Value == 3 && pos6Value == 2 && pos9Value == 1
                                && (pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.2 - 110 Points");
                    tablePoint += 110;
                }
                //Checking Sequence 3
                if ((pos1Value == 1 && pos2Value == 2 && pos3Value == 3 && !(pos1Color == pos2Color && pos2Color == pos3Color)
                        && !(pos1Color != pos2Color && pos2Color != pos3Color && pos1Color != pos3Color))
                        || (pos1Value == 3 && pos2Value == 2 && pos3Value == 1
                                && !(pos1Color == pos2Color && pos2Color == pos3Color)
                                && !(pos1Color != pos2Color && pos2Color != pos3Color && pos1Color != pos3Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.3 - 100 Points");
                    tablePoint += 100;
                }
                if ((pos4Value == 1 && pos5Value == 2 && pos6Value == 3 && !(pos4Color == pos5Color && pos5Color == pos6Color)
                        && !(pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color))
                        || (pos4Value == 3 && pos5Value == 2 && pos6Value == 1
                                && !(pos4Color == pos5Color && pos5Color == pos6Color)
                                && !(pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.3 - 100 Points");
                    tablePoint += 100;
                }
                if ((pos7Value == 1 && pos8Value == 2 && pos9Value == 3 && !(pos7Color == pos8Color && pos8Color == pos9Color)
                        && !(pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color))
                        || (pos7Value == 3 && pos8Value == 2 && pos9Value == 1
                                && !(pos7Color == pos8Color && pos8Color == pos9Color)
                                && !(pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.3 - 100 Points");
                    tablePoint += 100;
                }

                if ((pos1Value == 1 && pos5Value == 2 && pos9Value == 3 && !(pos1Color == pos5Color && pos5Color == pos9Color)
                        && !(pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color))
                        || (pos1Value == 3 && pos5Value == 2 && pos9Value == 1
                                && !(pos1Color == pos5Color && pos5Color == pos9Color)
                                && !(pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.3 - 100 Points");
                    tablePoint += 100;
                }

                if ((pos3Value == 1 && pos5Value == 2 && pos7Value == 3 && !(pos3Color == pos5Color && pos5Color == pos7Color)
                        && !(pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color))
                        || (pos3Value == 3 && pos5Value == 2 && pos7Value == 1
                                && !(pos3Color == pos5Color && pos5Color == pos7Color)
                                && !(pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.3 - 100 Points");
                    tablePoint += 100;
                }

                if ((pos1Value == 1 && pos4Value == 2 && pos7Value == 3 && !(pos1Color == pos4Color && pos4Color == pos7Color)
                        && !(pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color))
                        || (pos1Value == 3 && pos4Value == 2 && pos7Value == 1
                                && !(pos1Color == pos4Color && pos4Color == pos7Color)
                                && !(pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.3 - 100 Points");
                    tablePoint += 100;
                }

                if ((pos2Value == 1 && pos5Value == 2 && pos8Value == 3 && !(pos2Color == pos5Color && pos5Color == pos8Color)
                        && !(pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color))
                        || (pos2Value == 3 && pos5Value == 2 && pos8Value == 1
                                && !(pos2Color == pos5Color && pos5Color == pos8Color)
                                && !(pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.3 - 100 Points");
                    tablePoint += 100;
                }

                if ((pos3Value == 1 && pos6Value == 2 && pos9Value == 3 && !(pos3Color == pos6Color && pos6Color == pos9Color)
                        && !(pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color))
                        || (pos3Value == 3 && pos6Value == 2 && pos9Value == 1
                                && !(pos3Color == pos6Color && pos6Color == pos9Color)
                                && !(pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color)))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.3 - 100 Points");
                    tablePoint += 100;

                }
                //checking sequence 4

                deuOrdered = (pos1Value == 1 && pos2Value == 2 && pos3Value == 3)
                        || (pos1Value == 3 && pos2Value == 2 && pos3Value == 1);
                if (!deuOrdered && (pos1Value != pos2Value && pos2Value != pos3Value && pos1Value != pos3Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos2Value == 1 || pos2Value == 2 || pos2Value == 3)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos1Color == pos2Color && pos2Color == pos3Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.4 - 90 Points");
                    tablePoint += 90;
                }

                deuOrdered = (pos4Value == 1 && pos5Value == 2 && pos6Value == 3)
                        || (pos4Value == 3 && pos5Value == 2 && pos6Value == 1);
                if (!deuOrdered && (pos4Value != pos5Value && pos5Value != pos6Value && pos4Value != pos6Value)
                        && (pos4Value == 1 || pos4Value == 2 || pos4Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos6Value == 1 || pos6Value == 2 || pos6Value == 3)
                        && (pos4Color == pos5Color && pos5Color == pos6Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.4 - 90 Points");
                    tablePoint += 90;
                }

                deuOrdered = (pos7Value == 1 && pos8Value == 2 && pos9Value == 3)
                        || (pos7Value == 3 && pos8Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos7Value != pos8Value && pos8Value != pos9Value && pos7Value != pos9Value)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && (pos8Value == 1 || pos8Value == 2 || pos8Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && (pos7Color == pos8Color && pos8Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.4 - 90 Points");
                    tablePoint += 90;
                }

                deuOrdered = (pos1Value == 1 && pos5Value == 2 && pos9Value == 3)
                        || (pos1Value == 3 && pos5Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos1Value != pos5Value && pos5Value != pos9Value && pos1Value != pos9Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && (pos1Color == pos5Color && pos5Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.4 - 90 Points");
                    tablePoint += 90;
                }

                deuOrdered = (pos3Value == 1 && pos5Value == 2 && pos7Value == 3)
                        || (pos3Value == 3 && pos5Value == 2 && pos7Value == 1);
                if (!deuOrdered && (pos3Value != pos5Value && pos5Value != pos7Value && pos3Value != pos7Value)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && (pos3Color == pos5Color && pos5Color == pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.4 - 90 Points");
                    tablePoint += 90;
                }

                deuOrdered = (pos1Value == 1 && pos4Value == 2 && pos7Value == 3)
                        || (pos1Value == 3 && pos4Value == 2 && pos7Value == 1);
                if (!deuOrdered && (pos1Value != pos4Value && pos4Value != pos7Value && pos1Value != pos7Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos4Value == 1 || pos4Value == 2 || pos4Value == 3)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && (pos1Color == pos4Color && pos4Color == pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.4 - 90 Points");
                    tablePoint += 90;
                }

                deuOrdered = (pos2Value == 1 && pos5Value == 2 && pos8Value == 3)
                        || (pos2Value == 3 && pos5Value == 2 && pos8Value == 1);
                if (!deuOrdered && (pos2Value != pos5Value && pos5Value != pos8Value && pos2Value != pos8Value)
                        && (pos2Value == 1 || pos2Value == 2 || pos2Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos8Value == 1 || pos8Value == 2 || pos8Value == 3)
                        && (pos2Color == pos5Color && pos5Color == pos8Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.4 - 90 Points");
                    tablePoint += 90;
                }

                deuOrdered = (pos3Value == 1 && pos6Value == 2 && pos9Value == 3)
                        || (pos3Value == 3 && pos6Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos3Value != pos6Value && pos6Value != pos9Value && pos3Value != pos9Value)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos6Value == 1 || pos6Value == 2 || pos6Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && (pos3Color == pos6Color && pos6Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.4 - 90 Points");
                    tablePoint += 90;
                }
                //Checking sequence 5

                deuOrdered = (pos1Value == 1 && pos2Value == 2 && pos3Value == 3)
                        || (pos1Value == 3 && pos2Value == 2 && pos3Value == 1);
                if (!deuOrdered && (pos1Value != pos2Value && pos2Value != pos3Value && pos1Value != pos3Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos2Value == 1 || pos2Value == 2 || pos2Value == 3)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos1Color != pos2Color && pos2Color != pos3Color && pos1Color != pos3Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.5 - 80 Points");
                    tablePoint += 80;
                }

                deuOrdered = (pos4Value == 1 && pos5Value == 2 && pos6Value == 3)
                        || (pos4Value == 3 && pos5Value == 2 && pos6Value == 1);
                if (!deuOrdered && (pos4Value != pos5Value && pos5Value != pos6Value && pos4Value != pos6Value)
                        && (pos4Value == 1 || pos4Value == 2 || pos4Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos6Value == 1 || pos6Value == 2 || pos6Value == 3)
                        && (pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.5 - 80 Points");
                    tablePoint += 80;
                }

                deuOrdered = (pos7Value == 1 && pos8Value == 2 && pos9Value == 3)
                        || (pos7Value == 3 && pos8Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos7Value != pos8Value && pos8Value != pos9Value && pos7Value != pos9Value)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && (pos8Value == 1 || pos8Value == 2 || pos8Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && (pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.5 - 80 Points");
                    tablePoint += 80;
                }

                deuOrdered = (pos1Value == 1 && pos5Value == 2 && pos9Value == 3)
                        || (pos1Value == 3 && pos5Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos1Value != pos5Value && pos5Value != pos9Value && pos1Value != pos9Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && (pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.5 - 80 Points");
                    tablePoint += 80;
                }

                deuOrdered = (pos3Value == 1 && pos5Value == 2 && pos7Value == 3)
                        || (pos3Value == 3 && pos5Value == 2 && pos7Value == 1);
                if (!deuOrdered && (pos3Value != pos5Value && pos5Value != pos7Value && pos3Value != pos7Value)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && (pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.5 - 80 Points");
                    tablePoint += 80;
                }

                deuOrdered = (pos1Value == 1 && pos4Value == 2 && pos7Value == 3)
                        || (pos1Value == 3 && pos4Value == 2 && pos7Value == 1);
                if (!deuOrdered && (pos1Value != pos4Value && pos4Value != pos7Value && pos1Value != pos7Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos4Value == 1 || pos4Value == 2 || pos4Value == 3)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && (pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.5 - 80 Points");
                    tablePoint += 80;
                }

                deuOrdered = (pos2Value == 1 && pos5Value == 2 && pos8Value == 3)
                        || (pos2Value == 3 && pos5Value == 2 && pos8Value == 1);
                if (!deuOrdered && (pos2Value != pos5Value && pos5Value != pos8Value && pos2Value != pos8Value)
                        && (pos2Value == 1 || pos2Value == 2 || pos2Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos8Value == 1 || pos8Value == 2 || pos8Value == 3)
                        && (pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.5 - 80 Points");
                    tablePoint += 80;
                }

                deuOrdered = (pos3Value == 1 && pos6Value == 2 && pos9Value == 3)
                        || (pos3Value == 3 && pos6Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos3Value != pos6Value && pos6Value != pos9Value && pos3Value != pos9Value)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos6Value == 1 || pos6Value == 2 || pos6Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && (pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.5 - 80 Points");
                    tablePoint += 80;
                }
                //Checking sequence 6

                deuOrdered = (pos1Value == 1 && pos2Value == 2 && pos3Value == 3)
                        || (pos1Value == 3 && pos2Value == 2 && pos3Value == 1);
                if (!deuOrdered && (pos1Value != pos2Value && pos2Value != pos3Value && pos1Value != pos3Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos2Value == 1 || pos2Value == 2 || pos2Value == 3)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && !(pos1Color == pos2Color && pos2Color == pos3Color)
                        && (pos1Color == pos2Color || pos2Color == pos3Color || pos1Color == pos3Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.6 - 70 Points");
                    tablePoint += 70;
                }

                deuOrdered = (pos4Value == 1 && pos5Value == 2 && pos6Value == 3)
                        || (pos4Value == 3 && pos5Value == 2 && pos6Value == 1);
                if (!deuOrdered && (pos4Value != pos5Value && pos5Value != pos6Value && pos4Value != pos6Value)
                        && (pos4Value == 1 || pos4Value == 2 || pos4Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos6Value == 1 || pos6Value == 2 || pos6Value == 3)
                        && !(pos4Color == pos5Color && pos5Color == pos6Color)
                        && (pos4Color == pos5Color || pos5Color == pos6Color || pos4Color == pos6Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.6 - 70 Points");
                    tablePoint += 70;
                }

                deuOrdered = (pos7Value == 1 && pos8Value == 2 && pos9Value == 3)
                        || (pos7Value == 3 && pos8Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos7Value != pos8Value && pos8Value != pos9Value && pos7Value != pos9Value)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && (pos8Value == 1 || pos8Value == 2 || pos8Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && !(pos7Color == pos8Color && pos8Color == pos9Color)
                        && (pos7Color == pos8Color || pos8Color == pos9Color || pos7Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.6 - 70 Points");
                    tablePoint += 70;
                }

                deuOrdered = (pos1Value == 1 && pos5Value == 2 && pos9Value == 3)
                        || (pos1Value == 3 && pos5Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos1Value != pos5Value && pos5Value != pos9Value && pos1Value != pos9Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && !(pos1Color == pos5Color && pos5Color == pos9Color)
                        && (pos1Color == pos5Color || pos5Color == pos9Color || pos1Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.6 - 70 Points");
                    tablePoint += 70;
                }

                deuOrdered = (pos3Value == 1 && pos5Value == 2 && pos7Value == 3)
                        || (pos3Value == 3 && pos5Value == 2 && pos7Value == 1);
                if (!deuOrdered && (pos3Value != pos5Value && pos5Value != pos7Value && pos3Value != pos7Value)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && !(pos3Color == pos5Color && pos5Color == pos7Color)
                        && (pos3Color == pos5Color || pos5Color == pos7Color || pos3Color == pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.6 - 70 Points");
                    tablePoint += 70;
                }

                deuOrdered = (pos1Value == 1 && pos4Value == 2 && pos7Value == 3)
                        || (pos1Value == 3 && pos4Value == 2 && pos7Value == 1);
                if (!deuOrdered && (pos1Value != pos4Value && pos4Value != pos7Value && pos1Value != pos7Value)
                        && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && (pos4Value == 1 || pos4Value == 2 || pos4Value == 3)
                        && (pos7Value == 1 || pos7Value == 2 || pos7Value == 3)
                        && !(pos1Color == pos4Color && pos4Color == pos7Color)
                        && (pos1Color == pos4Color || pos4Color == pos7Color || pos1Color == pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.6 - 70 Points");
                    tablePoint += 70;
                }

                deuOrdered = (pos2Value == 1 && pos5Value == 2 && pos8Value == 3)
                        || (pos2Value == 3 && pos5Value == 2 && pos8Value == 1);
                if (!deuOrdered && (pos2Value != pos5Value && pos5Value != pos8Value && pos2Value != pos8Value)
                        && (pos2Value == 1 || pos2Value == 2 || pos2Value == 3)
                        && (pos5Value == 1 || pos5Value == 2 || pos5Value == 3)
                        && (pos8Value == 1 || pos8Value == 2 || pos8Value == 3)
                        && !(pos2Color == pos5Color && pos5Color == pos8Color)
                        && (pos2Color == pos5Color || pos5Color == pos8Color || pos2Color == pos8Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.6 - 70 Points");
                    tablePoint += 70;
                }

                deuOrdered = (pos3Value == 1 && pos6Value == 2 && pos9Value == 3)
                        || (pos3Value == 3 && pos6Value == 2 && pos9Value == 1);
                if (!deuOrdered && (pos3Value != pos6Value && pos6Value != pos9Value && pos3Value != pos9Value)
                        && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && (pos6Value == 1 || pos6Value == 2 || pos6Value == 3)
                        && (pos9Value == 1 || pos9Value == 2 || pos9Value == 3)
                        && !(pos3Color == pos6Color && pos6Color == pos9Color)
                        && (pos3Color == pos6Color || pos6Color == pos9Color || pos3Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.6 - 70 Points");
                    tablePoint += 70;
                }
                //Checking Sequence 7
                if (pos1Value == pos2Value && pos2Value == pos3Value && pos1Color == pos2Color && pos2Color == pos3Color)
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.7 - 60 Points");
                    tablePoint += 60;
                }

                if (pos4Value == pos5Value && pos5Value == pos6Value && pos4Color == pos5Color && pos5Color == pos6Color)
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.7 - 60 Points");
                    tablePoint += 60;
                }

                if (pos7Value == pos8Value && pos8Value == pos9Value && pos7Color == pos8Color && pos8Color == pos9Color)
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.7 - 60 Points");
                    tablePoint += 60;
                }

                if (pos1Value == pos5Value && pos5Value == pos9Value && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && pos1Color == pos5Color && pos5Color == pos9Color)
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.7 - 60 Points");
                    tablePoint += 60;
                }

                if (pos3Value == pos5Value && pos5Value == pos7Value && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && pos3Color == pos5Color && pos5Color == pos7Color)
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.7 - 60 Points");
                    tablePoint += 60;
                }

                if (pos1Value == pos4Value && pos4Value == pos7Value && (pos1Value == 1 || pos1Value == 2 || pos1Value == 3)
                        && pos1Color == pos4Color && pos4Color == pos7Color)
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.7 - 60 Points");
                    tablePoint += 60;
                }

                if (pos2Value == pos5Value && pos5Value == pos8Value && (pos2Value == 1 || pos2Value == 2 || pos2Value == 3)
                        && pos2Color == pos5Color && pos5Color == pos8Color)
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.7 - 60 Points");
                    tablePoint += 60;
                }

                if (pos3Value == pos6Value && pos6Value == pos9Value && (pos3Value == 1 || pos3Value == 2 || pos3Value == 3)
                        && pos3Color == pos6Color && pos6Color == pos9Color)
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.7 - 60 Points");
                    tablePoint += 60;
                }
                ///Checking Sequence 8 
                if (pos1Value == pos2Value && pos2Value == pos3Value && pos1Color != pos2Color && pos2Color != pos3Color
                        && pos1Color != pos3Color)
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.8 - 50 Points");
                    tablePoint += 50;
                }

                if (pos4Value == pos5Value && pos5Value == pos6Value
                        && pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color)
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.8 - 50 Points");
                    tablePoint += 50;
                }

                if (pos7Value == pos8Value && pos8Value == pos9Value
                        && pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color)
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.8 - 50 Points");
                    tablePoint += 50;
                }

                if (pos1Value == pos5Value && pos5Value == pos9Value
                        && pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color)
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.8 - 50 Points");
                    tablePoint += 50;
                }

                if (pos3Value == pos5Value && pos5Value == pos7Value
                        && pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color)
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.8 - 50 Points");
                    tablePoint += 50;
                }

                if (pos1Value == pos4Value && pos4Value == pos7Value
                        && pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color)
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.8 - 50 Points");
                    tablePoint += 50;
                }

                if (pos2Value == pos5Value && pos5Value == pos8Value
                        && pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color)
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.8 - 50 Points");
                    tablePoint += 50;
                }

                if (pos3Value == pos6Value && pos6Value == pos9Value
                        && pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color)
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.8 - 50 Points");
                    tablePoint += 50;
                }
                //Checking Sequence 9
                if (pos1Value == pos2Value && pos2Value == pos3Value
                        && !(pos1Color == pos2Color && pos2Color == pos3Color)
                        && !(pos1Color != pos2Color && pos2Color != pos3Color && pos1Color != pos3Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.9 - 40 Points");
                    tablePoint += 40;
                }

                if (pos4Value == pos5Value && pos5Value == pos6Value
                        && !(pos4Color == pos5Color && pos5Color == pos6Color)
                        && !(pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.9 - 40 Points");
                    tablePoint += 40;
                }

                if (pos7Value == pos8Value && pos8Value == pos9Value
                        && !(pos7Color == pos8Color && pos8Color == pos9Color)
                        && !(pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.9 - 40 Points");
                    tablePoint += 40;
                }

                if (pos1Value == pos5Value && pos5Value == pos9Value
                        && !(pos1Color == pos5Color && pos5Color == pos9Color)
                        && !(pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.9 - 40 Points");
                    tablePoint += 40;
                }

                if (pos3Value == pos5Value && pos5Value == pos7Value
                        && !(pos3Color == pos5Color && pos5Color == pos7Color)
                        && !(pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.9 - 40 Points");
                    tablePoint += 40;
                }

                if (pos1Value == pos4Value && pos4Value == pos7Value
                        && !(pos1Color == pos4Color && pos4Color == pos7Color)
                        && !(pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.9 - 40 Points");
                    tablePoint += 40;
                }

                if (pos2Value == pos5Value && pos5Value == pos8Value
                        && !(pos2Color == pos5Color && pos5Color == pos8Color)
                        && !(pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.9 - 40 Points");
                    tablePoint += 40;
                }

                if (pos3Value == pos6Value && pos6Value == pos9Value
                        && !(pos3Color == pos6Color && pos6Color == pos9Color)
                        && !(pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.9 - 40 Points");
                    tablePoint += 40;
                }
                //Checking Sequence 10
                if (!(pos1Value == pos2Value && pos2Value == pos3Value)
                        && !(pos1Value != pos2Value && pos2Value != pos3Value && pos1Value != pos3Value)
                        && (pos1Color == pos2Color && pos2Color == pos3Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row1:Seq.10 - 30 Points");
                    tablePoint += 30;
                }

                if (!(pos4Value == pos5Value && pos5Value == pos6Value)
                        && !(pos4Value != pos5Value && pos5Value != pos6Value && pos4Value != pos6Value)
                        && (pos4Color == pos5Color && pos5Color == pos6Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row2:Seq.10 - 30 Points");
                    tablePoint += 30;
                }

                if (!(pos7Value == pos8Value && pos8Value == pos9Value)
                        && !(pos7Value != pos8Value && pos8Value != pos9Value && pos7Value != pos9Value)
                        && (pos7Color == pos8Color && pos8Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Row3:Seq.10 - 30 Points");
                    tablePoint += 30;
                }

                if (!(pos1Value == pos5Value && pos5Value == pos9Value)
                        && !(pos1Value != pos5Value && pos5Value != pos9Value && pos1Value != pos9Value)
                        && (pos1Color == pos5Color && pos5Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag1:Seq.10 - 30 Points");
                    tablePoint += 30;
                }

                if (!(pos3Value == pos5Value && pos5Value == pos7Value)
                        && !(pos3Value != pos5Value && pos5Value != pos7Value && pos3Value != pos7Value)
                        && (pos3Color == pos5Color && pos5Color == pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Diag2:Seq.10 - 30 Points");
                    tablePoint += 30;
                }

                if (!(pos1Value == pos4Value && pos4Value == pos7Value)
                        && !(pos1Value != pos4Value && pos4Value != pos7Value && pos1Value != pos7Value)
                        && (pos1Color == pos4Color && pos4Color == pos7Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col1:Seq.10 - 30 Points");
                    tablePoint += 30;
                }

                if (!(pos2Value == pos5Value && pos5Value == pos8Value)
                        && !(pos2Value != pos5Value && pos5Value != pos8Value && pos2Value != pos8Value)
                        && (pos2Color == pos5Color && pos5Color == pos8Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col2:Seq.10 - 30 Points");
                    tablePoint += 30;
                }

                if (!(pos3Value == pos6Value && pos6Value == pos9Value)
                        && !(pos3Value != pos6Value && pos6Value != pos9Value && pos3Value != pos9Value)
                        && (pos3Color == pos6Color && pos6Color == pos9Color))
                {
                    if (printSeq)
                        Console.WriteLine("Col3:Seq.10 - 30 Points");
                    tablePoint += 30;
                }
                //Checking Sequence 11
                if (!(pos1Value == pos2Value && pos2Value == pos3Value)
                        && !(pos1Value != pos2Value && pos2Value != pos3Value && pos1Value != pos3Value)
                        && (pos1Color != pos2Color && pos2Color != pos3Color && pos1Color != pos3Color))
                {
                    if (printSeq) Console.WriteLine("Row1:Seq.11 20 Points");
                    tablePoint += 20;
                }

                if (!(pos4Value == pos5Value && pos5Value == pos6Value)
                        && !(pos4Value != pos5Value && pos5Value != pos6Value && pos4Value != pos6Value)
                        && (pos4Color != pos5Color && pos5Color != pos6Color && pos4Color != pos6Color))
                {
                    if (printSeq) Console.WriteLine("Row2:Seq.11 20 Points");
                    tablePoint += 20;
                }

                if (!(pos7Value == pos8Value && pos8Value == pos9Value)
                        && !(pos7Value != pos8Value && pos8Value != pos9Value && pos7Value != pos9Value)
                        && (pos7Color != pos8Color && pos8Color != pos9Color && pos7Color != pos9Color))
                {
                    if (printSeq) Console.WriteLine("Row3:Seq.11 20 Points");
                    tablePoint += 20;
                }

                if (!(pos1Value == pos5Value && pos5Value == pos9Value)
                        && !(pos1Value != pos5Value && pos5Value != pos9Value && pos1Value != pos9Value)
                        && (pos1Color != pos5Color && pos5Color != pos9Color && pos1Color != pos9Color))
                {
                    if (printSeq) Console.WriteLine("Diag1:Seq.11 20 Points");
                    tablePoint += 20;
                }

                if (!(pos3Value == pos5Value && pos5Value == pos7Value)
                        && !(pos3Value != pos5Value && pos5Value != pos7Value && pos3Value != pos7Value)
                        && (pos3Color != pos5Color && pos5Color != pos7Color && pos3Color != pos7Color))
                {
                    if (printSeq) Console.WriteLine("Diag2:Seq.11 20 Points");
                    tablePoint += 20;
                }

                if (!(pos1Value == pos4Value && pos4Value == pos7Value)
                        && !(pos1Value != pos4Value && pos4Value != pos7Value && pos1Value != pos7Value)
                        && (pos1Color != pos4Color && pos4Color != pos7Color && pos1Color != pos7Color))
                {
                    if (printSeq) Console.WriteLine("Col1:Seq.11 20 Points");
                    tablePoint += 20;
                }

                if (!(pos2Value == pos5Value && pos5Value == pos8Value)
                        && !(pos2Value != pos5Value && pos5Value != pos8Value && pos2Value != pos8Value)
                        && (pos2Color != pos5Color && pos5Color != pos8Color && pos2Color != pos8Color))
                {
                    if (printSeq) Console.WriteLine("Col2:Seq.11 20 Points");
                    tablePoint += 20;
                }

                if (!(pos3Value == pos6Value && pos6Value == pos9Value)
                        && !(pos3Value != pos6Value && pos6Value != pos9Value && pos3Value != pos9Value)
                        && (pos3Color != pos6Color && pos6Color != pos9Color && pos3Color != pos9Color))
                {
                    if (printSeq) Console.WriteLine("Col3:Seq.11 20 Points");
                    tablePoint += 20;
                }
                //Console.WriteLine("TABLEPOINT: : : : :" + tablePoint);
                if (i == -1)
                {
                    userPoint += tablePoint;
                    computerPoint += tablePoint;
                    tablePoint = 0;
                }
                if (secLoop == computerMode)
                {
                    maxPoint = tablePoint;
                    //Console.WriteLine(" COMPUTER Point ADDED" + maxPoint);
                    computerPoint += maxPoint;
                    maxPoint = 0;
                }
                if (i % 2 == 0 && i != -1)
                {
                    //Console.WriteLine(" USER Point ADDED" + tablePoint);
                    secLoop = computerMode+1;
                    userPoint += tablePoint;
                    tablePoint = 0;
                    Console.WriteLine();
                    maxPoint = 0;
                    maxColor = 0;
                    maxPosition = -1;
                    maxValue = 0;
                }
                if (i % 2 != 0 && secLoop < computerMode+1 && i != -1)
                {
                    // depending on the values, updating the maxPoint
                    if (tablePoint > maxPoint)
                    {
                        maxPoint = tablePoint;
                        maxPosition = tempPosition;
                        maxColor = tempColor;
                        maxValue = tempValue;
                    }
                    tablePoint = 0;

                    // changing back the old values
                    switch (tempPosition)
                    {
                        case 0:
                            pos1Value = originalValue;
                            pos1Color = originalColor;
                            break;
                        case 1:
                            pos2Value = originalValue;
                            pos2Color = originalColor;
                            break;
                        case 2:
                            pos3Value = originalValue;
                            pos3Color = originalColor;
                            break;
                        case 3:
                            pos4Value = originalValue;
                            pos4Color = originalColor;
                            break;
                        case 4:
                            pos5Value = originalValue;
                            pos5Color = originalColor;
                            break;
                        case 5:
                            pos6Value = originalValue;
                            pos6Color = originalColor;
                            break;
                        case 6:
                            pos7Value = originalValue;
                            pos7Color = originalColor;
                            break;
                        case 7:
                            pos8Value = originalValue;
                            pos8Color = originalColor;
                            break;
                        case 8:
                            pos9Value = originalValue;
                            pos9Color = originalColor;
                            break;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("User's Point: " + userPoint);
            Console.WriteLine("Computer's Point: " + computerPoint);
            for (int n = 0; n < 4; n++)
            {
                switch (rand.Next(9))
                {
                    case 0:
                        pos1Value = rand.Next(3) + 1;
                        pos1Color = rand.Next(3) + 1;
                        break;
                    case 1:
                        pos2Value = rand.Next(3) + 1;
                        pos2Color = rand.Next(3) + 1;
                        break;
                    case 2:
                        pos3Value = rand.Next(3) + 1;
                        pos3Color = rand.Next(3) + 1;
                        break;
                    case 3:
                        pos4Value = rand.Next(3) + 1;
                        pos4Color = rand.Next(3) + 1;
                        break;
                    case 4:
                        pos5Value = rand.Next(3) + 1;
                        pos5Color = rand.Next(3) + 1;
                        break;
                    case 5:
                        pos6Value = rand.Next(3) + 1;
                        pos6Color = rand.Next(3) + 1;
                        break;
                    case 6:
                        pos7Value = rand.Next(3) + 1;
                        pos7Color = rand.Next(3) + 1;
                        break;
                    case 7:
                        pos8Value = rand.Next(3) + 1;
                        pos8Color = rand.Next(3) + 1;
                        break;
                    case 8:
                        pos9Value = rand.Next(3) + 1;
                        pos9Color = rand.Next(3) + 1;
                        break;
                }
            }
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
        else
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Y       Y     OOOOO     U       U       L           OOOOO      SSSSS     EEEEE\r\n Y     Y    O       O   U       U       L         O       O   S       S   E\r\n   Y Y     O         O  U       U       L        O           S           E\r\n    Y      O         O  U       U       L        O             SSSSS     EEEE\r\n    Y      O         O  U       U       L        O                   S   E\r\n    Y       O       O    U     U        L         O       O   S       S   E\r\n    Y         OOOOO       UUUUU         LLLLLLL     OOOOO      SSSSS     EEEEE\r\n");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("User's Point: " + userPoint);
            Console.WriteLine("Computer's Point: " + computerPoint);
        }
        Console.ReadLine();
    }
}

