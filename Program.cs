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
        bool printSeq = true;// setting for default

        // 1 stands for D and Red
        // 2 stands for E and Green
        // 3 stands for U and Blue
        // For example 1,1 -> Red D, 2,1 -> Green E

        Random rand = new Random(); //Random Objects Created

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
        //checking sequence 4
        bool deuOrdered;

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

        // Code block of the Computer move
        int maxPoint = 0, maxPosition = -1, maxColor = 0, maxValue = 0;
        Random rd = new Random();
        printSeq = false;
    
        for (int i = 0; i < 25; i++) {
            // Assigning random values
            int tempValue = rd.Next(3) + 1;
            int tempColor = rd.Next(3) + 1;
            int tempPosition = rd.Next(9);
    
            // Creating temp values
            int originalValue = 0;
            int originalColor = 0;
    
            switch (tempPosition) {
                case 0:
                    originalValue = pos1Value;
                    originalColor = pos1Color;
                    pos1Value = tempValue;
                    pos1Color = tempColor;
                    break;
                case 1:
                    originalValue = pos2Value;
                    originalColor = pos2Color;
                    pos2Value = tempValue;
                    pos2Color = tempColor;
                    break;
                case 2:
                    originalValue = pos3Value;
                    originalColor = pos3Color;
                    pos3Value = tempValue;
                    pos3Color = tempColor;
                    break;
                case 3:
                    originalValue = pos4Value;
                    originalColor = pos4Color;
                    pos4Value = tempValue;
                    pos4Color = tempColor;
                    break;
                case 4:
                    originalValue = pos5Value;
                    originalColor = pos5Color;
                    pos5Value = tempValue;
                    pos5Color = tempColor;
                    break;
                case 5:
                    originalValue = pos6Value;
                    originalColor = pos6Color;
                    pos6Value = tempValue;
                    pos6Color = tempColor;
                    break;
                case 6:
                    originalValue = pos7Value;
                    originalColor = pos7Color;
                    pos7Value = tempValue;
                    pos7Color = tempColor;
                    break;
                case 7:
                    originalValue = pos8Value;
                    originalColor = pos8Color;
                    pos8Value = tempValue;
                    pos8Color = tempColor;
                    break;
                case 8:
                    originalValue = pos9Value;
                    originalColor = pos9Color;
                    pos9Value = tempValue;
                    pos9Color = tempColor;
                    break;
            }
    
            tablePoint = 0;
            // there should we should calculate the table point WILL BE ADDED
    
            // depending on the values, updating the maxPoint
            if (tablePoint > maxPoint) {
                maxPoint = tablePoint;
                maxPosition = tempPosition;
                maxColor = tempColor;
                maxValue = tempValue;
            }
    
            // changing back the old values
            switch (tempPosition) {
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
    
        // updating the best scenario
        if (maxPosition != -1) {
            switch (maxPosition) {
                case 0:
                    pos1Value = maxValue;
                    pos1Color = maxColor;
                    break;
                case 1:
                    pos2Value = maxValue;
                    pos2Color = maxColor;
                    break;
                case 2:
                    pos3Value = maxValue;
                    pos3Color = maxColor;
                    break;
                case 3:
                    pos4Value = maxValue;
                    pos4Color = maxColor;
                    break;
                case 4:
                    pos5Value = maxValue;
                    pos5Color = maxColor;
                    break;
                case 5:
                    pos6Value = maxValue;
                    pos6Color = maxColor;
                    break;
                case 6:
                    pos7Value = maxValue;
                    pos7Color = maxColor;
                    break;
                case 7:
                    pos8Value = maxValue;
                    pos8Color = maxColor;
                    break;
                case 8:
                    pos9Value = maxValue;
                    pos9Color = maxColor;
                    break;
            }
        }
        printSeq = true;


        // Printing board
        Console.WriteLine("   1 2 3");
        Console.WriteLine(" +--------+");
        for (int j = 0; j < 3; j++)
        {
            Console.Write((j + 1) + "| ");
            for (int k = 0; k < 3; k++)
            {
                int posIndex = j * 3 + k; // Calculate position index
                int value = 0, color = 0;

                // Determine the value and color based on position index
                // Each case corresponds to a specific cell on the 3x3 board
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
                // If value is 1, it represents "D" with different color symbols
                if (value == 1)
                {
                    if (color == 1)
                    {
                        displayChar = "D."; // Red
                    }
                    else if (color == 2)
                    {
                        displayChar = "D "; // Green
                    }
                    else if (color == 3)
                    {
                        displayChar = "D_"; // Blue
                    }
                }
                // If value is 2, it represents "E" with different color symbols
                else if (value == 2)
                {
                    if (color == 1)
                    {
                        displayChar = "E."; // Red
                    }
                    else if (color == 2)
                    {
                        displayChar = "E "; // Green
                    }
                    else if (color == 3)
                    {
                        displayChar = "E_"; // Blue
                    }
                }
                // If value is 3, it represents "U" with different color symbols
                else if (value == 3)
                {
                    if (color == 1)
                    {
                        displayChar = "U."; // Red
                    }
                    else if (color == 2)
                    {
                        displayChar = "U "; // Green
                    }
                    else if (color == 3)
                    {
                        displayChar = "U_"; // Blue
                    }
                }

                Console.Write(displayChar); // Print the character on the board
            }
            Console.Write(" |");
            Console.WriteLine();
        }
        Console.WriteLine(" +--------+");
        // Declare variables for position values and colors
        int pos1Value, pos1Color;
        int pos2Value, pos2Color;
        int pos3Value, pos3Color;
        int pos4Value, pos4Color;
        int pos5Value, pos5Color;
        int pos6Value, pos6Color;
        int pos7Value, pos7Color;
        int pos8Value, pos8Color;
        int pos9Value, pos9Color;

        int inputPos; // Variable to hold the user-selected position

        // Prompt user for the position to edit
        Console.WriteLine("Enter a Position to Edit (1-9):");
        inputPos = Convert.ToInt32(Console.ReadLine()) - 1; // Convert input to zero-based index

        // Validate input position
        if (inputPos < 0 || inputPos > 8)
        {
            Console.WriteLine("Invalid position. Please enter a number between 1 and 9.");
            return; // Exit if the position is out of range
        }

        // Prompt user for the new letter value
        Console.WriteLine("Enter The New Letter (1-D, 2-E, 3-U):");
        int inputValue = Convert.ToInt32(Console.ReadLine()); // Get the new letter value

        // Validate letter input
        if (inputValue < 1 || inputValue > 3)
        {
            Console.WriteLine("Invalid letter choice. Please enter 1, 2, or 3.");
            return; // Exit if the letter input is invalid
        }

        // Prompt user for the new color
        Console.WriteLine("Enter The New Color (1-Red, 2-Green, 3-Blue):");
        int inputColor = Convert.ToInt32(Console.ReadLine()); // Get the new color value

        // Validate color input
        if (inputColor < 1 || inputColor > 3)
        {
            Console.WriteLine("Invalid color choice. Please enter 1, 2, or 3.");
            return; // Exit if the color input is invalid
        }

        // Update the corresponding position based on user input
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
        }

        // Confirm to the user that the position has been updated
        Console.WriteLine("Position updated successfully!");

    }
}
