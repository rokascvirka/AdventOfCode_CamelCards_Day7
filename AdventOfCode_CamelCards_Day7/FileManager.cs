using AdventOfCode_CamelCards_Day7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_CamelCards_Day7
{
    public static class FileManager
    {
        public static List<GameModel> ReadData(string path)
        {
            List<GameModel> gameModel = new List<GameModel>();
            using(StreamReader sr = new StreamReader(path))
            {
                var text = sr.ReadToEnd().Split(Environment.NewLine);
                foreach(var line in text)
                {
                    var data = line.Split(" ");
                    var cards = data[0];
                    var bet = int.Parse(data[1].ToString());
                    gameModel.Add(new GameModel(cards, bet));
                    
                }
            }
            return gameModel;
        }
    }
}
