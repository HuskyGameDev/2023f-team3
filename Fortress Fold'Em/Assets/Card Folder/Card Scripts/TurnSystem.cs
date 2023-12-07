using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public TMP_Text turnText;
    [SerializeField] public GameObject endButton;
    [SerializeField] public AudioSource getHit;
    [SerializeField] public AudioSource endPTurn;
    [SerializeField] public AudioSource endETurn;

    public TMP_Text manaText;

    public static bool startTurn;

    // Start is called before the first frame update
    void Start()
    {
        isYourTurn = true;

        startTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isYourTurn)
        {
            turnText.text = "Your Turn";
        }
        else
        {
            turnText.text = "Enemy Turn";
        }
    }

    public void EndTurn()
    {
        isYourTurn = false;
        endButton.SetActive(false);
        endPTurn.Play();

        Invoke("EnemyTurn", 2);
    }

    public void EnemyTurn()
    {
        PlayerHP.staticHPP -= Random.Range(1, 31);
        getHit.Play();
        endETurn.Play();

        isYourTurn = true;

        if (ManaValue.staticM < ManaValue.maxM && ManaValue.addedM == 0)
        {
            ManaValue.staticM = ManaValue.maxM;
        }
        else if (ManaValue.addedM != 0)
        {
            ManaValue.staticM = ManaValue.maxM + ManaValue.addedM;
            ManaValue.addedM = 0;
        }

        startTurn = true;
        endButton.SetActive(true);
    }

}
