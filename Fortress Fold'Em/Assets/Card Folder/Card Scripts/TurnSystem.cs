using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TurnSystem : MonoBehaviour
{
    public bool isYourTurn;
    public int yourTurn;
    public int isEnemyTurn;
    public TMP_Text turnText;

    public int maxMana;
    public int currentMana;
    public TMP_Text manaText;

    public static bool startTurn;

    // Start is called before the first frame update
    void Start()
    {
        isYourTurn = true;
        yourTurn = 1;
        isEnemyTurn = 0;

        maxMana = 5;
        currentMana = 5;
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

        manaText.text = currentMana + "/" + maxMana;
    }

    public void EndTurn()
    {
        if (isYourTurn)
        {
            isYourTurn = false;
            isEnemyTurn += 1;

            currentMana = 0;
        }
        else
        {
            isYourTurn = true;
            yourTurn += 1;

            currentMana = maxMana;
            startTurn = true;
        }

    }

}
