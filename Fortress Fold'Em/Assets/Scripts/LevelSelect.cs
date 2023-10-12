using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update

    public Button first, second, third, fourth, boss;
    public GameObject optionsScreen, pauseScreen;

    void Start()
    {
        
    }

    public void enterLevel(string level)
    {
        Navigation auto = new Navigation();
        auto.mode = Navigation.Mode.Automatic;
        Navigation none = new Navigation();
        none.mode = Navigation.Mode.None;
        switch (level)
        {
            case "FIRST":
                first.interactable = false;
                first.navigation = none;
                second.interactable = true;
                second.navigation = auto;
                break;
            case "SECOND":
                second.interactable = false;
                second.navigation = none;
                third.interactable = true;
                third.navigation = auto;
                break;
            case "THIRD":
                third.interactable = false;
                third.navigation = none;
                fourth.interactable = true;
                fourth.navigation = auto;
                break;
            case "FOURTH":
                fourth.interactable = false;
                fourth.navigation = none;
                boss.interactable = true;
                boss.navigation = auto;
                break;
            case "BOSS":
                boss.interactable = false;
                boss.navigation = none;
                first.interactable = true;
                first.navigation = auto;
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
            pauseScreen.SetActive(true);
        }
    }

    public void Unpause()
    {
        Time.timeScale = 1.0f;
        pauseScreen.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
