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

        public static List<GameModel> RateCards(List<GameModel> cards, List<string> cardStrengths) 
        {
            var rank = 1;
            var index = 0;
            var sortedCards = SortByCombination(cards);
            var nothing = sortedCards.Where(x => x.Combination == HandsPower.Nothing).ToList(); 
            var onePair  = sortedCards.Where(x => x.Combination == HandsPower.OnePair).ToList();
            var twoPair = sortedCards.Where(x => x.Combination == HandsPower.TwoPair).ToList();
            var threePair = sortedCards.Where(x => x.Combination == HandsPower.ThreePair).ToList();
            var fourOfAKind = sortedCards.Where(x => x.Combination == HandsPower.FourOfAKind).ToList();
            var fiveOfAKind = sortedCards.Where(x => x.Combination == HandsPower.FiveOfAKind).ToList();
            var fullHouse = sortedCards.Where(x => x.Combination == HandsPower.FullHouse).ToList();


            foreach(var hand in twoPair)
            {
                if(twoPair.Count == 1)
                {
                    hand.Rank = rank;
                    rank += 1;
                    continue;
                }
                else
                {

                    for(var i = 0; i < 5; i++) 
                    { 
                        var isHandSet = false;
                        for(var j = 0; j < 13; j++)
                        {
                            var symbol = cardStrengths[j];
                            var indexOfSymbol = cardStrengths.IndexOf(symbol);

                            var result = twoPair.Where(cards => cards.Rank == 0 && cards.CardsAsIntList[i] == indexOfSymbol && cards.CardsAsList[i] == symbol).ToList();
                            if (result.Count == 1)
                            {
                                result[0].Rank = rank;
                                rank += 1;
                                isHandSet = true;
                                Console.WriteLine($"Hand = {result[0].Game}, rank: {result[0].Rank}");
                                break;
                            }

                            if (result.Count > 1)
                            {
                                continue;
                            }

                        }
                        if (isHandSet)
                        {
                            break;
                        }
                    }

                }
            }

            return new List<GameModel>();
            
        }

        private static List<GameModel> SortByCombination(List<GameModel> cards) 
        {
            var sorted = cards.OrderBy(x => x.Value);
            return sorted.ToList();
        }
    }
}
