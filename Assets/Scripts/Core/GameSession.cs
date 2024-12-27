using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CatteScoreboard.Scripts.Core
{

    public class GameSession
    {
        public string SessionName { get; set; }
        public DateTime SessionTime { get; set; }
        public Scoreboard SessionRecord { get; set; }

        public GameSession(string Name)
        {
            SessionName = Name;
            SessionTime = DateTime.Now;
            SessionRecord = new Scoreboard();
        }
    }
}

