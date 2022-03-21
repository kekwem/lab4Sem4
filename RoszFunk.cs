using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_i_metody_rozszerzajace
{
    public static class RoszFunk
    {
        public static string zwCo2(this string str)
        {
            string str_M = str.ToLower();
            string str_W = str.ToUpper();
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result += str_W[i];
                }
                else
                {
                    result += str_M[i];
                }
            }
            return result;
        }

        public static string usunSamog(this string str)
        {
            string talica = "eyuioaEYUIOA";
            string result = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (!talica.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            return result;
        }

        public static int[] dlugosciWyrazow(this string str)
        {
            string[] tablica_str = str.Split(' ');
            if (tablica_str[0].Length == 0)
            {
                int[] tablica_int = new int[tablica_str.Length - 1];
                for (int i = 1; i < tablica_str.Length; i++)
                {
                    tablica_int[i - 1] = tablica_str[i].Length;
                }
                return tablica_int;
            }
            else
            {
                int[] tablica_int = new int[tablica_str.Length];
                for (int i = 0; i < tablica_str.Length; i++)
                {
                    tablica_int[i] = tablica_str[i].Length;
                }
                return tablica_int;
            }
        }

        public static bool czyZdanie(this string str)
        {
            if (str[0].ToString().Equals(new string(str[0], 1).ToUpper()) &&
                str[str.Length - 1].ToString().Equals("."))
            {
                return true;
            }
            return false;
        }
    }
}
