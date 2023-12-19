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
        public List<string> CardsAsList { get; set; }
        public List<int> CardsAsIntList { get; set; }
        public int Bet {  get; set; }
        public HandsPower Combination { get; set; } 
        public float Value { get; set; }    
        public int Rank { get; set; }


        public GameModel(string game, int bet) 
        { 
            Game = game;
            CardsAsList = game.Select(x => x.ToString()).ToList();
            CardsAsIntList = GetIntList(CardsAsList);
            Bet = bet;
            Combination = GetCombination(game);
            Value = CombinationValue(Combination);
            Rank = SetRank();
        }

        private HandsPower GetCombination(string game)
        {
            var combinations = new CombinationsModel();
            var repetitions = Calculator.CountRepetitions(game);
            if(repetitions.SequenceEqual(combinations.OnePair))
            {
                return HandsPower.OnePair;
            }
            if(repetitions.SequenceEqual(combinations.TwoPair))
            {
                return HandsPower.TwoPair;
            }
            if(repetitions.SequenceEqual(combinations.ThreeOfAKind))
            {
                return HandsPower.ThreePair;
            }
            if(repetitions.SequenceEqual(combinations.FourOfAKind))
            {
                return HandsPower.FourOfAKind;
            }
            if(repetitions.SequenceEqual(combinations.FiveOfAKind))
            {
                return HandsPower.FiveOfAKind;
            }
            if(repetitions.SequenceEqual(combinations.FullHouse))
            {
                return HandsPower.FullHouse;
            }
            else
            {
                return HandsPower.Nothing;
            }
        }

        private float CombinationValue(HandsPower hands)
        {

            return (int)hands;
        }


        private List<int> GetIntList(List<string> gameAsList)
        {
            var strengthOfCards = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };
            List<int> result = new List<int>();
            foreach(var card in gameAsList) 
            {
                var index = strengthOfCards.IndexOf(card);
                result.Add(index);
            }

            return result;
        }

        private int SetRank() 
        {
            return 0;
        }


    }
}
    