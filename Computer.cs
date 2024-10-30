using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DEU_Lettters_Game.Game;


    class Computer
    {
        public static void computer()
        {
            int maxPoint = 0, maxPosition = -1, maxColor = 0, maxValue = 0;
            Random rd = new Random();
            printSeq = false;

            for (int i = 0; i < 25; i++)
            {
                // Rastgele değerler oluştur
                int tempValue = rd.Next(3) + 1;
                int tempColor = rd.Next(3) + 1;
                int tempPosition = rd.Next(9);

                // Mevcut pozisyonu geçici olarak değiştir
                int originalValue = 0;
                int originalColor = 0;

                switch (tempPosition)
                {
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

                // Geçici değişiklik yapıldıktan sonra puanı kontrol et
                tablePoint = 0;
                //checkSequences(); // Burada mevcut pozisyon değişikliği kontrol ediliyor

                // En iyi puanı bul
                if (tablePoint > maxPoint)
                {
                    maxPoint = tablePoint;
                    maxPosition = tempPosition;
                    maxColor = tempColor;
                    maxValue = tempValue;
                }

                // Geçici değerleri geri yükle
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

            // En iyi pozisyondaki değeri güncelle
            if (maxPosition != -1)
            {
                switch (maxPosition)
                {
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
        }

    public static void computer1()
    {
        int maxPoint = 0, maxPosition = -1, maxColor = 0, maxValue = 0;
        Random rd = new Random();
        printSeq = false;

        for (int i = 0; i < 50; i++)
        {
            // Rastgele değerler oluştur
            int tempValue = rd.Next(3) + 1;
            int tempColor = rd.Next(3) + 1;
            int tempPosition = rd.Next(9);

            // Mevcut pozisyonu geçici olarak değiştir
            int originalValue = 0;
            int originalColor = 0;

            switch (tempPosition)
            {
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

            // Geçici değişiklik yapıldıktan sonra puanı kontrol et
            tablePoint = 0;
            //checkSequences(); // Burada mevcut pozisyon değişikliği kontrol ediliyor

            // En iyi puanı bul
            if (tablePoint > maxPoint)
            {
                maxPoint = tablePoint;
                maxPosition = tempPosition;
                maxColor = tempColor;
                maxValue = tempValue;
            }

            // Geçici değerleri geri yükle
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

        // En iyi pozisyondaki değeri güncelle
        if (maxPosition != -1)
        {
            switch (maxPosition)
            {
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
    }

    public static void computer2()
    {
        int maxPoint = 0, maxPosition = -1, maxColor = 0, maxValue = 0;
        Random rd = new Random();
        printSeq = false;

        for (int i = 0; i < 100; i++)
        {
            // Rastgele değerler oluştur
            int tempValue = rd.Next(3) + 1;
            int tempColor = rd.Next(3) + 1;
            int tempPosition = rd.Next(9);

            // Mevcut pozisyonu geçici olarak değiştir
            int originalValue = 0;
            int originalColor = 0;

            switch (tempPosition)
            {
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

            // Geçici değişiklik yapıldıktan sonra puanı kontrol et
            tablePoint = 0;
            //checkSequences(); // Burada mevcut pozisyon değişikliği kontrol ediliyor

            // En iyi puanı bul
            if (tablePoint > maxPoint)
            {
                maxPoint = tablePoint;
                maxPosition = tempPosition;
                maxColor = tempColor;
                maxValue = tempValue;
            }

            // Geçici değerleri geri yükle
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

        // En iyi pozisyondaki değeri güncelle
        if (maxPosition != -1)
        {
            switch (maxPosition)
            {
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
    }
}

