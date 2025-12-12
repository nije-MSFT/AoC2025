using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day6
{
    internal class Part2
    {
        public long ReturnVal;

        public Part2()
        {
            var lines = File.ReadAllLines("Input.txt");
            var numberLines = new List<List<string>>
            {
                ([])
            };

            for (int x = lines[0].Length - 1; x >= 0; x--)
            {
                var sb = new char[4];

                for (int y = 0; y <= lines.Length - 2; y++)
                {
                    sb[y] = lines[y][x];
                }

                var number = new string(sb).Trim();

                if (string.IsNullOrEmpty(number))
                {
                    numberLines.Add(new List<string>());
                }
                else
                {
                    numberLines.Last().Add(number);
                }

                if (lines[lines.Length - 1][x] !=  ' ')
                {
                    numberLines.Last().Add(lines[lines.Length - 1][x].ToString());
                }
            }

            foreach (var line in numberLines)
            {
                var operation = line.Last();
                line.RemoveAt(line.Count - 1);

                long solution = long.Parse(line[0]);

                foreach (var numberAsString in line.Skip(1))
                {
                    var number = long.Parse(numberAsString);

                    if (operation == "*")
                    {
                        solution *= number;
                    }
                    else
                    {
                        solution += number;
                    }
                }

                ReturnVal += solution;
            }
        }
    }
}
