﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3Lab05
{
    class TestExcep
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Enter a number :");
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if (intNum <= 0)
                {
                    throw new InvalidInput();
                }
            }
            catch (InvalidInput objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            } catch (System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            } finally
            {
                if (intNum > 0)
                {
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                        Console.WriteLine(intCnt * intNum);
                }
            }
            Console.ReadLine();
        }
    }
}

