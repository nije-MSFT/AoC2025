using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Day6
{
    internal class Part1
    {
        public long ReturnVal;

        public Part1()
        {
            var lines = File.ReadAllLines("Input.txt");
            var numberLines = new List<List<string>>();

            foreach (var line in lines)
            {
                int x = 0;

                foreach (var item in line.Split(' '))
                {
                    if (item != string.Empty)
                    {
                        if (x == numberLines.Count)
                        {
                            numberLines.Add(new List<string>());
                        }

                        numberLines[x].Add(item);
                        x++;
                    }
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
