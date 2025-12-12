using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Text;

namespace Day6
{
    internal class Part2
    {
        public long ReturnVal;

        public Part2()
        {
            var lines = File.ReadAllLines("Input.txt");
            var ranges = new List<(long start, long end)>();

            int x = 0;

            while (lines[x] != string.Empty)
            {
                var split = lines[x].Split('-');
                var start = long.Parse(split[0]);
                var end = long.Parse(split[1]);
                x++;

                int y = 0;

                while (y < ranges.Count)
                {
                    if (start >= ranges[y].start && end <= ranges[y].end)
                    {
                        break;
                    }
                    else if (start >= ranges[y].start && start <= ranges[y].end && end > ranges[y].end)
                    {
                        start = Math.Min(start, ranges[y].start);
                        ranges.RemoveAt(y);
                    }
                    else if (end >= ranges[y].start && end <= ranges[y].end && start < ranges[y].start)
                    {
                        end = Math.Max(end, ranges[y].end);
                        ranges.RemoveAt(y);
                    }
                    else if (start < ranges[y].start && end > ranges[y].end)
                    {
                        ranges.RemoveAt(y);
                    }
                    else
                    {
                        y++;
                    }
                }

                if (y == ranges.Count)
                {
                    ranges.Add((start, end));
                }
            }

            foreach (var range in ranges)
            {
                ReturnVal += (range.end - range.start + 1);
            }
        }
    }
}
