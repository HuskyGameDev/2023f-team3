using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OptionSceen : MonoBehaviour
{
    public Toggle fullscreenTog;
    public List<ResItem> resolutions = new List<ResItem>();
    private int selectedResolution = 0;
    public TMP_Text resolutionText;

    // Start is called before the first frame update
    void Start()
    {
        fullscreenTog.isOn = Screen.fullScreen;

        bool foundRes = false;
        for (int i = 0; i < resolutions.Count; i++) 
        {
            if (Screen.width == resolutions[i].hor && Screen.height == resolutions[i].vert)
            {
                foundRes = true;

                selectedResolution = i;

                updateResText();
            }
        }

        if (!foundRes)
        {
            ResItem newRes = new ResItem();
            newRes.hor = Screen.width;
            newRes.vert = Screen.height;

            resolutions.Add(newRes);
            selectedResolution = resolutions.Count - 1;

            updateResText();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void resLeft()
    {
        if (selectedResolution != 0)
        {
            selectedResolution--;
        }
        updateResText();
    }
    public void resRight()
    {
        if (selectedResolution != resolutions.Count-1)
        {
            selectedResolution++;
        }
        updateResText();
    }

    public void updateResText()
    {
        resolutionText.text = resolutions[selectedResolution].hor.ToString() + " x " + resolutions[selectedResolution].vert.ToString();
    }
    public void ApplyGraphics()
    {
        Screen.SetResolution(resolutions[selectedResolution].hor, resolutions[selectedResolution].vert, fullscreenTog.isOn);
    }
}

[System.Serializable]
public class ResItem
{
    public int hor, vert;
}