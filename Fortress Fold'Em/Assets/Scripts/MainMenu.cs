using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject optionsScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
