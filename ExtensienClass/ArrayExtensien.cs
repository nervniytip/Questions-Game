using System;
using System.Collections.Generic;
using System.Text;

namespace Questions_Game
{
    static class ArrayExtensien
    {
        /// <summary>
        /// Перемешивает массив <T>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        public static void Shufel<T>(this T[] array)
        {
            Random random = new Random();
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);

                T s = array[j];
                array[j] = array[i];
                array[i] = s;
            }
        }
    }
}
