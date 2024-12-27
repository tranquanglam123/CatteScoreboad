using CatteScoreboard.Scripts.Interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CatteScoreboard.Scripts.Core
{
    public class CustomData
    {
    }
    public class GameSessionsManager 
    {
        public List<GameSession> GameSessions;
        public GameSessionsManager()
        {
            GameSessions = new List<GameSession>();
        }
        public void AddGameSession(string Name)
        {
            GameSessions.Add(new GameSession(Name));
        }
        public void RemoveGameSession(string Name)
        {
            GameSessions.RemoveAll(x => x.SessionName == Name);
        }
        public void Clear()
        {
            GameSessions.Clear();
        }
        public List<GameSession> GetGameSessions()
        {
            return GameSessions;
        }
    }
    public class Scoreboard : IScoreboard
    {
        public List<List<int>> Scores;
        public List<Player> PLayers;

        public Scoreboard()
        {
            Scores = new List<List<int>>();
            PLayers = new List<Player>();
        }

        public List<Player> GetPlayers()
        {
            return PLayers;
        }

        public List<List<int>> GetScores()
        {
            return Scores;
        }
        /// <summary>
        /// Create a new round with 0 scores for each player
        /// </summary>
        public void AddRound()
        {
            var newRound = new List<int>(new int[PLayers.Count]);
            Scores.Add(newRound);
        }
        /// <summary>
        /// Add the new Player to the Player List, also add a new column to each round
        /// </summary>
        /// <param name="PlayerName"></param>
        public void AddPlayer(string PlayerName)
        {
            foreach (var round in Scores)
            {
                round.Add(0);
            }
            PLayers.Add(new Player(PlayerName));
        }
        /// <summary>
        /// Set the winner of the round, set the others to -1
        /// </summary>
        /// <param name="Round"></param>
        /// <param name="PlayerIndex"></param>
        public void RecordWin(int Round, int PlayerIndex)
        {
            for (int i = 0; i < PLayers.Count; i++)
            {
                if(i == PlayerIndex)
                {
                    Scores[Round][i] = PLayers.Count - 1;
                    PLayers[i].RecordWin();
                }
                else
                {
                    Scores[Round][i] = -1;
                    PLayers[i].RecordLoss();
                }
            }
        }

    }
}

