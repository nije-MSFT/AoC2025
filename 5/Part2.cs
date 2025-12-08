using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day5
{
    internal class Part2
    {
        public long ReturnVal;

        public Part2()
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

            foreach (var range in ranges)
            {
            }
        }
    }
}
