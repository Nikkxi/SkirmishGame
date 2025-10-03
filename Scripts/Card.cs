using System;
using Godot;
using SkirmishGame.Resources;

namespace SkirmishGame.Cards
{
    public partial class Card : Node
    {
        [Export]
        public Resource CardData { get; set; }

        public Sprite2D Artwork { get; set; }


        public override void _Ready()
        {
            
        }

    }
}