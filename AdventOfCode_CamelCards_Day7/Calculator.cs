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
        public static List<int> CountRepetitions(string game, List<string> games)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < games.Count; i++)
            {
                int count = 0;
                string currentGame = games[i];

                for (int startIndex = 0; startIndex <= game.Length - currentGame.Length;)
                {
                    if (game.IndexOf(currentGame, startIndex) == startIndex)
                    {
                        count++;
                        startIndex += currentGame.Length;
                    }
                    else
                    {
                        startIndex++;
                    }
                }

                result.Add(count);
            }

            return result;
        }
    }
}
