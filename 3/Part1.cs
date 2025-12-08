using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    internal class Part1
    {
        public long ReturnVal;

        public Part1()
        {
            var lines = File.ReadAllLines("Input.txt");

            foreach (var line in lines)
            {
                var first = 0;
                var second = 0;

                for (int x = 0; x < line.Length; x ++)
                {
                    int number = line[x] - '0';

                    if (number > first && x + 1 < line.Length)
                    {
                        first = number;
                        second = 0;
                    }
                    else if (number > second)
                    {
                        second = number;
                    }
                }

                var answer = (first * 10) + second;
                ReturnVal += answer;
            }
        }
    }
}
