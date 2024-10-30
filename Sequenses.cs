using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DEU_Lettters_Game.Game;

namespace DEU_Lettters_Game
{
    internal class Sequenses
    {
        public static void CheckSequences()
        {

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
        }
    }
}
