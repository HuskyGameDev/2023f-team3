using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
    public int id;
    public string cardName;
    public int cost;
    public int power;
    public int type;
    public string cardDescription;
    public Sprite artwork;

    public Card()
    {

    }

    public Card(int Id, string CardName, int Cost, int Power, int Type, string CardDescription, Sprite Artwork)
    {
        id = Id;
        cardName = CardName;
        cost = Cost;
        power = Power;
        type = Type;
        cardDescription = CardDescription;
        artwork = Artwork;
    }
}
