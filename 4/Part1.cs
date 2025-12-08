using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day4
{
    internal class Part1
    {
        public long ReturnVal;

        public List<(int x, int y)> points = new List<(int x, int y)>()
        {
            (-1, -1), (0, -1), (1, -1),
            (-1, 0),           (1, 0),
            (-1, 1),  (0, 1),  (1, 1)
        };

        public Part1()
        {
            var lines = File.ReadAllLines("Input.txt");

            for (int y = 0; y < lines.Length; y++)
            {
                for (int x = 0; x < lines[y].Length; x++)
                {
                    if (lines[y][x] != '@')
                    {
                        continue;
                    }

                    var surrounding = 0;

                    foreach (var point in points)
                    {
                        if (GetCharAt(x + point.x, y + point.y, lines) == '@')
                        {
                            surrounding++;
                        }
                    }

                    if (surrounding < 4)
                    {
                        ReturnVal++;
                    }
                }
            }
        }

        public char GetCharAt(int x, int y, string[] lines)
        {
            if (y < 0 || y >= lines.Length)
            {
                return ' ';
            }
            if (x < 0 || x >= lines[y].Length)
            {
                return ' ';
            }
            return lines[y][x];
        }
    }
}
