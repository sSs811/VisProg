using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
  class Programm
  {
    static void Main(string[] args)
     {
     HW1.QueueTime(new int[] { 5, 3, 4 }, 1);
     HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2);
     HW1.QueueTime(new int[] { 2, 3, 10 }, 2);
     HW1.QueueTime(new int[] { 11, 2, 3, 5 }, 3);
     HW1.QueueTime(new int[] { 7, 6, 10 }, 3);
        }
  }
    
    
public class HW1
   {
    public static long QueueTime(int[] customers, int n)
     {

      int vv,i;
      int ix = n - 1;
      int ch=0;
      int[] kass = new int[n];
 
      for (i = 0; i < n; i++)
       {
        kass[i] = customers[i];
       } 

      while(true) 
       {

        for (i = 0; i < n; i++)
         {

          kass[i]= kass[i]- 1;
          ch = ch+ 1;
          if (kass[i] == 0)
           {

            if (customers.Length - 1<=ix && kass.Max() == 0)
             {

              while(ch % n != 0)
               {

                ch= ch + 1;
               }
              
              return ch/n;
              
             }

            else if (ix < customers.Length - 1)
             {
              kass[i] = customers[ix+1];
              ix+= 1;
             }
           }
         }
       }
     }
  }
}
