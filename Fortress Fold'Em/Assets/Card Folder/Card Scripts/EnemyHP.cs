using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public static float maxHPE;
    public static float staticHPE;
    public float hp;
    public Image Health;
    public TMP_Text hpText;

    // Start is called before the first frame update
    void Start()
    {
        maxHPE = 500;
        staticHPE = 132;
    }

    // Update is called once per frame
    void Update()
    {
        hp = staticHPE;
        Health.fillAmount = hp / maxHPE;

        if (hp > maxHPE)
        {
            hp = maxHPE;
        }

        hpText.text = hp + "/" + maxHPE;
    }
}
