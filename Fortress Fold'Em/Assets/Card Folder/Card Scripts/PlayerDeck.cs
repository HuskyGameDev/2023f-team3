using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeck : MonoBehaviour
{
    public List<Card> deck = new List<Card> ();
    private Card container;
    private int x;
    public static int deckSize;
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

        for(int i = 0; i < 20; i++)
        {
            x = Random.Range(1, 4);
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
    }

    IEnumerator StartGame()
    {
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(1);

            Instantiate(CardToHand, transform.position, transform.rotation);
        }
    }

    public void ShuffleDeck()
    {
        for (int i = 0; i < deckSize; i++)
        {
            container = deck[i];
            int randomIndex = Random.Range(i, deckSize);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = container;
        }
    }
}