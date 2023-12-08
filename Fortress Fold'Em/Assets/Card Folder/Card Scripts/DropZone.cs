using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] public AudioSource cardPlay1;
    [SerializeField] public AudioSource cardPlay2;
    [SerializeField] public AudioSource cardPlay3;

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("OnPointerEnter");
    }

    public void OnDrop(PointerEventData eventData)
    {
        //Debug.Log(eventData.pointerDrag.name + "was dropped to " + gameObject.name);
        int x = Random.Range(1, 4);
        DisplayCard c = eventData.pointerDrag.GetComponent<DisplayCard>();
        GameObject g = c.gameObject;

        if (c != null)
        {
            if (c.cost <= ManaValue.staticM)
            {
                //Debug.Log(c.id + " Was Played");
                if(c.type == 1)
                {
                    ManaValue.staticM -= c.cost;
                    PlayerHP.staticHPP += c.power;

                    if(x == 1)
                    {
                        cardPlay1.Play();
                    }
                    else if(x == 2)
                    {
                        cardPlay2.Play();
                    }
                    else if(x == 3)
                    {
                        cardPlay3.Play();
                    }

                    Destroy(g);
                    PlayerDeck.handSize -= 1;
                }
                else if(c.type == 2)
                {
                    ManaValue.staticM -= c.cost;
                    ManaValue.addedM += c.power;

                    if (x == 1)
                    {
                        cardPlay1.Play();
                    }
                    else if (x == 2)
                    {
                        cardPlay2.Play();
                    }
                    else if (x == 3)
                    {
                        cardPlay3.Play();
                    }

                    Destroy(g);
                    PlayerDeck.handSize -= 1;
                }
                else if(c.type == 3)
                {
                    ManaValue.staticM -= c.cost;
                    EnemyHP.staticHPE -= c.power;

                    if (x == 1)
                    {
                        cardPlay1.Play();
                    }
                    else if (x == 2)
                    {
                        cardPlay2.Play();
                    }
                    else if (x == 3)
                    {
                        cardPlay3.Play();
                    }

                    Destroy(g);
                    PlayerDeck.handSize -= 1;
                }
                else if(c.type == 4)
                {
                    ManaValue.staticM -= c.cost;
                    PlayerDeck.extraDraw += c.power;

                    if (x == 1)
                    {
                        cardPlay1.Play();
                    }
                    else if (x == 2)
                    {
                        cardPlay2.Play();
                    }
                    else if (x == 3)
                    {
                        cardPlay3.Play();
                    }

                    Destroy(g);
                    PlayerDeck.handSize -= 1;
                }

            }
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("OnPointerExit");
    }

}
