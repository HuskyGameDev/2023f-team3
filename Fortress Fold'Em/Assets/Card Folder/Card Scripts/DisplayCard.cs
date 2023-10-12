using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System.Reflection;

public class DisplayCard : MonoBehaviour
{
    public List<Card> displayCard = new List<Card>();
    public int displayId;

    public int id;
    public string cardName;
    public int cost;
    public int power;
    public int type;
    public string cardDescription;
    public Sprite artwork;


    public TMP_Text nameText;
    public TMP_Text costText;
    public TMP_Text descriptionText;
    public Image artImage;

    public bool cardBack;
    public static bool staticCardBack;

    public GameObject Hand;
    public int cardsInDeck;

    // Start is called before the first frame update
    void Start()
    {
        cardsInDeck = PlayerDeck.deckSize;

        displayCard[0] = CardDatabase.cardList[displayId];
        
    }

    // Update is called once per frame
    void Update()
    {
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        power = displayCard[0].power;
        type = displayCard[0].type;
        cardDescription = displayCard[0].cardDescription;
        artwork = displayCard[0].artwork;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        descriptionText.text = " " + cardDescription;
        artImage.sprite = artwork;

        Hand = GameObject.Find("Hand");
        if(this.transform.parent == Hand.transform.parent)
        {
            cardBack = false;
        }

        staticCardBack = cardBack;

        if(this.tag == "Clone")
        {
            displayCard[0] = PlayerDeck.staticDeck[cardsInDeck - 1];
            cardsInDeck -= 1;
            PlayerDeck.deckSize -= 1;
            cardBack = false;
            this.tag = "Untagged";
        }

    }
}
