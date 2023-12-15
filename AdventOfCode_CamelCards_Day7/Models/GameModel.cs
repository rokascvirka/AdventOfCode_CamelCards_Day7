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
            Combination = GetCombination(game, GameAsList);
            Value = CombinationValue(Combination);
            Rank = SetRank();
        }

        private string GetCombination(string game, List<string> games)
        {
            var combinations = new CombinationsModel();
            var repetitions = Calculator.CountRepetitions(game, games);
            if(repetitions == combinations.OnePair)
            {
                return "OnePair";
            }
            if(repetitions == combinations.TwoPair)
            {
                return "TwoPair";
            }
            if(repetitions == combinations.ThreeOfAKind)
            {
                return "ThreePair";
            }
            if(repetitions == combinations.FourOfAKind)
            {
                return "FourOfAKind";
            }
            if(repetitions == combinations.FiveOfAKind)
            {
                return "FiveOfAKind";
            }
            if(repetitions == combinations.FullHouse)
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
    