using System;
using System.Collections.Generic;

namespace Questions_Game
{
    static class ListExtensien
    {
        public static void Shufel<T>(this List<T> list)
        {
            Random random = new Random();
            for (int i = list.Count - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                T s = list[j];
                list[j] = list[i];
                list[i] = s;
            }
        }
    }
}
