using System;
using System.Collections.Generic;
using Godot;

namespace SkirmishGame.Resources
{
    public partial class CardData : Resource
    {

        [Export]
        public String FactionName;

        [Export]
        public String CardName;

        [Export]
        public String CardDescription;

        [Export]
        public String CardArtPath = "res://Artwork/placeholder.png";

        [Export]
        public String[] CardTypes;

        [Export]
        public String[] CardSubTypes;

        [Export]
        public int CardNumber;

        [Export]
        public int BuildCost;

        [Export]
        public int ScoutPower;

        [Export]
        public int Health;

        [Export]
        public int Initiative;

    }
}