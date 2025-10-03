using Godot;
using System;

namespace Skirmish.Cards;
public partial class Card : Node
{
    
    public Texture2D Artwork { get; set; }


    public override void _Ready()
    {
        GD.Print("Card ready");
    }

}
