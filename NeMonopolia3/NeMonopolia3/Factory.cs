using System;
namespace NeMonopolia3
{
    public class Factory
    {
        public enum TypeofFActory
        {
            first,
            second,
            three
        }
        public Factory()
        {
        }
        public int id;
        public int price;
        public int rent;
        public int security;
        public int bonus;
        public TypeofFActory type;
        public PlayerCharacteristic owner;

        public int changerIntellect;
        public int changerHonesty;
        public int changerCommunication;
        public int changerLuck;
        // public Geo location //locatin with creating class "Geo"
    }
}

