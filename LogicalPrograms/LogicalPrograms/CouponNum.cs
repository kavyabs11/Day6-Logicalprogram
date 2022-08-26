﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNum
    {
        public static int random()              //for random numbers from 1 to 20
        {
            Random ran = new Random();
            int r = ran.Next(1, 21);
            return r;
        }
        public static void distinct(int n)          //for distict numbers 
        {
            int[] ar = new int[n];
            for (int i = 0; i < n; i++)             //for storing numbers in an array
            {
                ar[i] = random();
                for (int j = 0; j < i; j++)         //loop from the 0th number to the outer loop index number 
                {
                    if (ar[i] == ar[j])             //to compare outer loop number with all the previous numbers
                    {
                        ar[i] = random();              //if finds the number equal, stores a random number in it 
                        i--;              //decreases the outer loop index by one and breaks the inner loop,
                        break;            // so that after increment in the outer loop same number is checked again for equality 
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(ar[i] + "  ");
            }
        }
    }
}
