using AdventOfCode_CamelCards_Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CamelCards_Day7
{
    public class Calculator
    {
        public static List<int> CountRepetitions(string input)
        {
            var counts = new List<int>();
            var visited = new HashSet<char>();

            foreach (char c in input)
            {
                if (!visited.Contains(c))
                {
                    int count = 0;
                    foreach (char x in input)
                    {
                        if (x == c)
                        {
                            count++;
                        }
                    }
                    counts.Add(count);
                    visited.Add(c);
                }
            }
            counts.Sort();
            return counts;
        }
    }
}
