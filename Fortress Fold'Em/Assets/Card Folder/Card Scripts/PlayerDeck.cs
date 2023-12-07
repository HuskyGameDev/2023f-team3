using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card> ();
    private Card container;
    private int x;
    public static int handSize;
    public static int deckSize;
    public static int extraDraw;
    public static List<Card> staticDeck = new List<Card>();

    public GameObject cardInDeck1;
    public GameObject cardInDeck2;
    public GameObject cardInDeck3;
    public GameObject cardInDeck4;

    public GameObject CardToHand;
    public GameObject[] Clone;
    public GameObject Hand;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        deckSize = 20;
        handSize = 0;
        extraDraw = 0;

        for(int i = 0; i < 20; i++)
        {
            x = Random.Range(1, 47);
            deck[i] = CardDatabase.cardList[x];
        }

        StartCoroutine(StartGame());
    }

    // Update is called once per frame
    void Update()
    {
        staticDeck = deck;
        if(deckSize < 20)
        {
            cardInDeck1.SetActive(false);
        }
        if (deckSize < 10)
        {
            cardInDeck2.SetActive(false);
        }
        if (deckSize < 5)
        {
            cardInDeck3.SetActive(false);
        }
        if (deckSize < 1)
        {
            cardInDeck4.SetActive(false);
        }

        if(TurnSystem.startTurn == true)
        {
            StartCoroutine(Draw(2 + extraDraw));
            extraDraw = 0;
            TurnSystem.startTurn = false;
        }
    }

    IEnumerator StartGame()
    {
        for (int i = 0; i < 5; i++)
        {
            if (handSize < 7)
            {
                yield return new WaitForSeconds(0);

                handSize += 1;
                Instantiate(CardToHand, transform.position, transform.rotation);
            }
        }
    }

    public void ShuffleDeck()
    {
        for (int i = 0; i < 20; i++)
        {
            x = Random.Range(1, 47);
            deck[i] = CardDatabase.cardList[x];
        }
    }

    IEnumerator Draw(int x)
    {
        for(int i = 0; i < x; i++)
        {
            yield return new WaitForSeconds(0);

            if (deckSize > 0)
            {
                if (handSize < 7)
                {
                    handSize += 1;
                    Instantiate(CardToHand, transform.position, transform.rotation);
                }
            }
            else
            {
                if (handSize < 7)
                {
                    //Debug.Log("ENTERED SHUFFLE TIME");
                    ShuffleDeck();
                    deckSize = 20;
                    cardInDeck1.SetActive(true);
                    cardInDeck2.SetActive(true);
                    cardInDeck3.SetActive(true);
                    cardInDeck4.SetActive(true);


                    handSize += 1;
                    Instantiate(CardToHand, transform.position, transform.rotation);
                }
            }
        }
    }
}
