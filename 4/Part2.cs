using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day4
{
    internal class Part2
    {
        public int ReturnVal;

        public List<(int x, int y)> points = new List<(int x, int y)>()
        {
            (-1, -1), (0, -1), (1, -1),
            (-1, 0),           (1, 0),
            (-1, 1),  (0, 1),  (1, 1)
        };

        public Part2()
        {
            List<char[]> charLines = new List<char[]>();   

            foreach (var line in File.ReadLines("Input.txt"))
            {
                charLines.Add(line.ToCharArray());
            }

            var priorReturn = -1;

            while (ReturnVal != priorReturn)
            {
                priorReturn = ReturnVal;
                for (int y = 0; y < charLines.Count; y++)
                {
                    for (int x = 0; x < charLines[y].Length; x++)
                    {
                        if (charLines[y][x] != '@')
                        {
                            continue;
                        }

                        var surrounding = 0;

                        foreach (var point in points)
                        {
                            if (GetCharAt(x + point.x, y + point.y, charLines) == '@')
                            {
                                surrounding++;
                            }
                        }

                        if (surrounding < 4)
                        {
                            ReturnVal++;
                            charLines[y][x] = ' ';
                        }
                    }
                }
            }
        }

        public char GetCharAt(int x, int y, List<char[]> lines)
        {
            if (y < 0 || y >= lines.Count)
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
