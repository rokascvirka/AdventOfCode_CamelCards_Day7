using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CamelCards_Day7.Models
{
    public class CombinationsModel
    {
        public List<int> FiveOfAKind = new List<int>() { 5 };
        public List<int> FourOfAKind = new List<int>() { 1, 4 }; 
        public List<int> FullHouse = new List<int> { 2, 3 };
        public List<int> ThreeOfAKind = new List<int>() { 1, 1 , 3 };
        public List<int> TwoPair = new List<int>() { 1, 2, 2 };
        public List<int> OnePair = new List<int>() { 1, 1, 1, 2 };
        public List<int> Nothing = new List<int>() { 1, 1, 1, 1, 1 };

    }
}
