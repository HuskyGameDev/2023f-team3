using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ManaValue : MonoBehaviour
{
    public static int maxM;
    public static int staticM;
    public static int addedM;
    public TMP_Text mText;

    // Start is called before the first frame update
    void Start()
    {
        maxM = 5;
        staticM = 5;
        addedM = 0;
    }

    // Update is called once per frame
    void Update()
    {
        mText.text = staticM + "/" + maxM;
    }
}
