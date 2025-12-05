using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    internal class Part1
    {
        public long ReturnVal;

        public Part1()
        {
            var lines = File.ReadAllLines("Input.txt");

            foreach (var range in lines[0].Split(','))
            {
                var startNumber = long.Parse(range.Split('-')[0]);
                var endNumber = long.Parse(range.Split('-')[1]);

                for (long i = startNumber; i <= endNumber; i++)
                {
                    var digits = (int)Math.Floor(Math.Log10(i) + 1);

                    if (digits % 2 == 1)
                    {
                        continue;
                    }

                    var firsthalf = i.ToString().Substring(0, digits / 2);
                    var secondhalf = i.ToString().Substring(digits / 2);

                    if (firsthalf == secondhalf)
                    {
                        ReturnVal+= i;
                    }
                }
            }
        }
    }
}
