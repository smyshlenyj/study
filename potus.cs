using System;

public class Kata
{
    public static bool AllAlone(char[][] house)
    {
        // Your code here
        int rec = 0;
        int pos_x = 0;
        int pos_y = 0;
        int status = 1;

        //  ищем POTUS
        for (int i = 0; i < house.Length; i++)
        {

            for (int j = 0; j < house[i].Length; j++)

                if (Array.IndexOf(house[i], 'X') > 0)
                {
                    pos_x = Array.IndexOf(house[i], 'X');
                    pos_y = i;
                    break;
                }

        }

        // ставим точку сбоку POTUS
        for (int i = -1; i <= 1; i++)
        {
            if (' '.CompareTo(house[pos_y][pos_x + i]) == 0)
            {
                house[pos_y][pos_x + i] = '.';
            }

            if (' '.CompareTo(house[pos_y + i][pos_x]) == 0)
            {
                house[pos_y + i][pos_x] = '.';
            }
        }

        // ищем точку с пыстым местом рядом и ставим на пустое точку
        while (rec < 100)
        {
            for (int i = 0; i < house.Length; i++)
            {

                for (int j = 0; j < house[i].Length; j++)
                {
                    if ('.'.CompareTo(house[i][j]) == 0 && ' '.CompareTo(house[i][j + 1]) == 0)
                    {
                        house[i][j + 1] = '.';
                    }
                }
                for (int j = 0; j < house[i].Length; j++)
                {
                    if ('.'.CompareTo(house[i][j]) == 0 && ' '.CompareTo(house[i][j - 1]) == 0)
                    {
                        house[i][j - 1] = '.';
                    }
                }
                for (int j = 0; j < house[i].Length; j++)
                {
                    if ('.'.CompareTo(house[i][j]) == 0 && ' '.CompareTo(house[i + 1][j]) == 0)
                    {
                        house[i + 1][j] = '.';
                    }
                }
                for (int j = 0; j < house[i].Length; j++)
                {
                    if ('.'.CompareTo(house[i][j]) == 0 && ' '.CompareTo(house[i - 1][j]) == 0)
                    {
                        house[i - 1][j] = '.';
                    }
                }

                //Ищем эльфа рядом с точкой
                for (int j = 0; j < house[i].Length; j++)
                {
                    if ('o'.CompareTo(house[i][j]) == 0 && ('.'.CompareTo(house[i][j + 1]) == 0 || '.'.CompareTo(house[i][j - 1]) == 0))
                    {
                        status = 0;
                    }
                        }
                for (int j = 0; j < house[i].Length; j++)
                {
                    if ('o'.CompareTo(house[i][j]) == 0 && ('.'.CompareTo(house[i + 1][j]) == 0 || '.'.CompareTo(house[i - 1][j]) == 0))
                    {
                        status = 0;
                    }
                }
            }
            rec++;
        }
        if (status == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }



    static void Main()
    {


        char[][] house =
        {
            "#################             ".ToCharArray(),
            "#     o         #   o         ".ToCharArray(),
            "#          ######        o    ".ToCharArray(),
            "####       #                  ".ToCharArray(),
            "   #       ###################".ToCharArray(),
            "   #    X                    #".ToCharArray(),
            "   #                         #".ToCharArray(),
            "   ###########################".ToCharArray()
        
        };
        AllAlone(house);
    }
}
