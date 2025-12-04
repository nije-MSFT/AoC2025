using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day1
{
    internal class Part2
    {
        public int ReturnVal;

        public Part2()
        {
            var lines = File.ReadAllLines("Input.txt");

            var position = 50;

            foreach (var line in lines)
            {
                var distance = int.Parse(line.Substring(1));

                bool startedAtZero = position == 0;

                position = line[0] == 'L' ?
                    (position - distance):
                    (position + distance);
                 
                ReturnVal += Math.Abs(position / 100);

                if (!startedAtZero && (position <= 0))
                {
                    ReturnVal++;
                }

                position = ((position % 100) + 100) % 100;
            }
        }
    }
}
