using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    internal class Part1
    {
        public int ReturnVal;

        public Part1()
        {
            var lines = File.ReadAllLines("Input.txt");

            var position = 50;

            foreach (var line in lines)
            {
                var distance = int.Parse(line.Substring(1));

                position = line[0] == 'L' ?
                    (position + 100 - distance) % 100 :
                    (position + distance) % 100;

                if (position == 0)
                {
                    ReturnVal++;
                }
            }
        }
    }
}
