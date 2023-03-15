using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManager.App.Model
{
    public class MaxRadix
    {
        //static public int[] Radixing(int[] countarray, int[] list)
        //{
        //    int[] temp = new int[list.Length];
        //    for (int i = 0; i < countarray.Length; i++)
        //    {
        //        if (i == 0) countarray[i] -= 1;
        //        else
        //        {
        //            countarray[i] = countarray[i - 1] + countarray[i];
        //        }
        //    }
        //    for (int i = temp.Length - 1; i > 0; i--)
        //    {
        //        temp[countarray[list[i]]] = list[i];
        //        countarray[list[i]]--;
        //    }
        //    return temp;
        //}
        static public string Radix(int[] list)
        {
            int[] countarray = new int[10];
            int[] temp = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                countarray[list[i]]++;
            }
            for (int i = 0; i < countarray.Length; i++)
            {
                if (i == 0) countarray[i] -= 1;
                else
                {
                    countarray[i] = countarray[i - 1] + countarray[i];
                }
            }
            for (int i = temp.Length - 1; i > 0; i--)
            {
                temp[countarray[list[i]]] = list[i];
                countarray[list[i]]--;
            }
            //list = Radixing(countarray, list);
            //countarray = new int[10];
            //for (int i = 0; i < list.Length; i++)
            //{
            //    countarray[list[i/10]]++;
            //}
            //list = Radixing(countarray, list);
            string result = "";
            foreach (int i in list) result += i.ToString() + ",";
            return result;
        }
    }
}
