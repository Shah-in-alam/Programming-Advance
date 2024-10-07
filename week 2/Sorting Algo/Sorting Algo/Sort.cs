using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algo
{
    internal class Sort
    {
        public void Bubble(int[] array)
        {
            for(int i =0; i< array.Length; i++)
            {
                for(int j =0; j< array.Length-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
        public void Bubble(string[] frut)
        {
            for(int i = 0; i< frut.Length; i++)
            {
                for (int j = 0; j< frut.Length - 1; j++)
                {
                    if (String.Compare(frut[j],frut[j+1]) >0)
                    {
                        string temp = frut[j];
                        frut[j]= frut[j+1];
                        frut[j+1]= temp;
                    }
                }
            }
        }
        public void Selection(int[] array)
        {
           
            for(int i = 0; i< array.Length; i++)
            {
                int min = array[i];
                int index = i;
                for(int J=i+1; J< array.Length; J++)
                {
                    if(array[J] < min)
                    {

                        min = array[J];
                        index = J;
                    }
                
                }
                int temp=array[i];
                array[i] = array[index];
                array[index] = temp;
            }

        }
        public void Insertion(int[] array)
        {
            // everthing before and after the by inputing the element
            for(int i =0;i<array.Length; i++)
            {
               int key = array[i];
               int j= i-1;

               while(j>=0 && array[j]> key)
                {
                   array[j+1] =array[j];
                    j--;
               }
               array[i] = key;
            }

            for(int i=array.Length-1; i>=0; i--)
            {
                int key = array[i];
                int j= i-1;
                while( j>=0 && array[j]> key)
                {
                    array[j+1] = array[j];
                    j=j+1;
                }
                array[i] = key;
            }
        }
    }
}
