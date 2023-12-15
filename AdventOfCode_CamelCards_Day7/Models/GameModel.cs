using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CamelCards_Day7.Models
{
    public class GameModel
    {
        public string Game { get; set; }
        public List<string> GameAsList { get; set; }
        public int Bet {  get; set; }
        public string Combination { get; set; } // Power of hand
        public float Value { get; set; }    
        public int Rank { get; set; }


        public GameModel(string game, int bet) 
        { 
            Game = game;
            GameAsList = game.Select(x => x.ToString()).ToList();
            Bet = bet;
            Combination = GetCombination(game);
            Value = CombinationValue(Combination);
            Rank = SetRank();
        }

        private string GetCombination(string game)
        {
            var combinations = new CombinationsModel();
            var repetitions = Calculator.CountRepetitions(game);
            if(repetitions.SequenceEqual(combinations.OnePair))
            {
                return "OnePair";
            }
            if(repetitions.SequenceEqual(combinations.TwoPair))
            {
                return "TwoPair";
            }
            if(repetitions.SequenceEqual(combinations.ThreeOfAKind))
            {
                return "ThreePair";
            }
            if(repetitions.SequenceEqual(combinations.FourOfAKind))
            {
                return "FourOfAKind";
            }
            if(repetitions.SequenceEqual(combinations.FiveOfAKind))
            {
                return "FiveOfAKind";
            }
            if(repetitions.SequenceEqual(combinations.FullHouse))
            {
                return "FullHouse";
            }
            else
            {
                return "Nothing";
            }
        }

        private float CombinationValue(string combination)
        {
            
            return 0;
        }

        private int SetRank() 
        {
            return 0;
        }


    }
}
    