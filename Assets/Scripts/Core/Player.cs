using UnityEngine.UI;
namespace CatteScoreboard.Scripts.Core
{

    public class Player
    {
        public string Name { get; set; }
        public Image Avatar { get; set; }
        public int Score { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public Player(string PlayerName)
        {
            Name = PlayerName;
        }
        public void RecordWin()
        {
            Wins++;
        }
        public void RecordLoss()
        {
            Losses++;
        }
    }
}

