using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        int pos1Value, pos2Value, pos3Value, pos4Value, pos5Value,// for each position (1-9) 
            pos6Value, pos7Value, pos8Value, pos9Value, pos1Color, // there exist 2 variables its color(RGB) 
            pos2Color, pos3Color, pos4Color, pos5Color, pos6Color, // and its letter value (DEU)
            pos7Color, pos8Color, pos9Color;  // user and computer points stored in userPoint, computerPoint

        int userPoint = 0; // user and computer points stored in userPoint, computerPoint
        int computerPoint = 0;
        int tablePoint = 0;  // table point refers to the point that current board holds
        bool printSeq = true;

        // 1 stands for D and Red
        // 2 stands for E and Green
        // 3 stands for U and Blue
        // For example 1,1 -> Red D, 2,1 -> Green E

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
        // Determining point by checking sequences

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
    }
}