using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();

    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, 0, "None", Resources.Load<Sprite>("TestImage1")));
        cardList.Add(new Card(1, "Card 1", 1, 1, 0, "This is Card 1", Resources.Load<Sprite>("TestImage1")));
        cardList.Add(new Card(2, "Card 2", 2, 2, 0, "This is Card 2", Resources.Load<Sprite>("TestImage2")));
        cardList.Add(new Card(3, "Card 3", 3, 3, 0, "This is Card 3", Resources.Load<Sprite>("TestImage3")));
        cardList.Add(new Card(4, "Card 4", 4, 4, 0, "This is Card 4", Resources.Load<Sprite>("TestImage1")));
    }
}
