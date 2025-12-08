using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    internal class Part2
    {
        public long ReturnVal;

        public Part2()
        {
            var lines = File.ReadAllLines("Input.txt");

            foreach (var line in lines)
            {
                int[] digits = [0,0,0,0,0,0,0,0,0,0,0,0];
                var position = digits.Length;
                int x = 0;
                int foundPos = 0;

                while (position > 0)
                {
                    while (x < line.Length)
                    {
                        if (x + position > line.Length)
                        {
                            break;
                        }

                        var currentNumber = line[x] - '0';

                        if (currentNumber > digits[Math.Abs(position - 12)])
                        {
                            digits[Math.Abs(position - 12)] = currentNumber;
                            foundPos = x;
                        }
                        x++;
                    }

                    x = foundPos + 1;
                    position--;
                }

                long foundNumber = 0;

                for (int i = 0; i < digits.Length ; i++)
                {
                    foundNumber = (foundNumber * 10) + digits[i];
                }

                ReturnVal += foundNumber;
            }
        }
    }
}
