using CatteScoreboard.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CatteScoreboard.Scripts.Interfaces
{
    public interface IScoreboard
    {
        void AddRound() { }
        void AddPlayer(string PlayerName) { }
        void RecordWin(int Round, int PlayerIndex) { }
        List<List<int>> GetScores();
        List<Player> GetPlayers();
    }

}
