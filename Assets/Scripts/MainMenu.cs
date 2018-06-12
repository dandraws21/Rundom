using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public GameObject black;
    private int timeCounter;
    
    public string playGameLevel;
    public string optionsLevel;
    public string charactersLevel;
    public string storeLevel;

    void Start()
    {
        black = GameObject.Find("black");
    }
    void Update()
    {
        timeCounter += 1;
        if(timeCounter >= 120)
        {
            black.gameObject.SetActive(false);
        }
    }

    public void PlayGame()
    {
        Application.LoadLevel(playGameLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void Options()
    {
        Application.LoadLevel(optionsLevel);
    }
    public void Store()
    {
        Application.LoadLevel(storeLevel);
    }
    public void Characters()
    {
        Application.LoadLevel(charactersLevel);
    }

}
