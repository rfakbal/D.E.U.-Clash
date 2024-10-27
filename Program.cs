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

    }
}