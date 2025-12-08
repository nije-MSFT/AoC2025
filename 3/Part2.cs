using System;
using System.Collections.Generic;
using System.Text;

namespace Day3 
{
    internal class Part2
    {
        public long ReturnVal;

        public Part2()
        {
            var lines = File.ReadAllLines("Input.txt");

            foreach (var range in lines[0].Split(','))
            {
                var startNumber = long.Parse(range.Split('-')[0]);
                var endNumber = long.Parse(range.Split('-')[1]);

                for (long i = startNumber; i <= endNumber; i++)
                {
                    var asString = i.ToString();
                    var digits = (int)Math.Floor(Math.Log10(i) + 1);

                    for (int d = digits / 2; d >= 1; d--)
                    {
                        if (digits % d != 0)
                        {
                            continue;
                        }

                        var stringToMatch = asString.Substring(0, d);

                        var index = d;
                        var foundMatch = true;

                        while (index + d <= digits)
                        {
                            if (asString.Substring(index, d) != stringToMatch)
                            {
                                foundMatch = false;
                                break;
                            }
                            index += d;
                        }

                        if (foundMatch)
                        {
                            ReturnVal += i;
                            break;
                        }
                    }
                }
            }
        }
    }
}
