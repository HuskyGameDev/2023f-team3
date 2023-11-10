using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public static float maxHPP;
    public static float staticHPP;
    public float hp;
    public Image Health;
    public TMP_Text hpText;

    // Start is called before the first frame update
    void Start()
    {
        maxHPP = 100;
        staticHPP = 71;
    }

    // Update is called once per frame
    void Update()
    {
        hp = staticHPP;
        Health.fillAmount = hp / maxHPP;

        if(hp > maxHPP)
        {
            hp = maxHPP;
        }

        hpText.text = hp + "/" + maxHPP;
    }
}
