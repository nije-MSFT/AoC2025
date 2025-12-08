using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day5
{
    internal class Part1
    {
        public long ReturnVal;

        public Part1()
        {
            var lines = File.ReadAllLines("Input.txt");
            var ranges = new List<(long start, long end)>();
            var ingredients = new List<long>();

            int x = 0;

            while (lines[x] != string.Empty)
            {
                var split = lines[x].Split('-');
                ranges.Add((long.Parse(split[0]), long.Parse(split[1])));
                x++;
            }

            x++; // Skip empty line
            
            while (x < lines.Length)
            {
                ingredients.Add(long.Parse(lines[x]));
                x++;
            }

            foreach (var ingredient in ingredients)
            {
                foreach (var range in ranges)
                {
                    if (ingredient >= range.start && ingredient <= range.end)
                    {
                        ReturnVal++;
                        break;
                    }
                }
            }
        }
    }
}
