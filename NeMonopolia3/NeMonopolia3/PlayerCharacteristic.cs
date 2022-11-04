using System;
using System.Collections.Generic;

namespace NeMonopolia3
{
    public class PlayerCharacteristic
    {
        public PlayerCharacteristic()
        {
        }
        public PlayerInfo Account;
        public int Money;
        public int Intellect;
        public int Honesty;
        public int Communication;
        public int Luck;
        public int Rank;
        public  List<Factory> Portfolio;
        public bool IsPlaying;
        public int StopCount;
    }
}

