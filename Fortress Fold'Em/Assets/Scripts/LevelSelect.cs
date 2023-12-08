using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update

    public Button level1, level2, level3, level4, level5, boss;
    public GameObject pauseMenu;

    void Start()
    {
        
    }

    public void enterLevel(string level)
    {
        switch (level)
        {
            case "L1":
                SceneManager.LoadScene("Main_Scene");
                break;
            case "L2":
                level2.gameObject.SetActive(false);
                level3.gameObject.SetActive(true);
                break;
            case "L3":
                level3.gameObject.SetActive(false);
                level4.gameObject.SetActive(true);
                break;
            case "L4":
                level4.gameObject.SetActive(false);
                level5.gameObject.SetActive(true);
                break;
            case "L5":
                level5.gameObject.SetActive(false);
                boss.gameObject.SetActive(true);
                break;
            case "B":
                boss.gameObject.SetActive(false);
                level1.gameObject.SetActive(true);
                break;
        }
        Debug.Log(level);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
        }
    }
}
