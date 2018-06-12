using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {
    
    //Screens
    public string logoLevel;
    public string mainMenuLevel;
    public string optionsLevel;
    public string gameplayLevel;

    // Update is called once per frame
	void Update () {
       
        // Nums

        if ((Input.GetKey(KeyCode.Alpha1))) // Logo
        {
            Logo();
        }
        if ((Input.GetKey(KeyCode.Alpha2))) // Menu
        {
            Menu();
        }
        if ((Input.GetKey(KeyCode.Alpha3))) // Options
        {
            Options();
        }
        if ((Input.GetKey(KeyCode.Alpha4))) // Gameplay
        {
            PlayGame();
        }
    }

    //Scenes

    public void Logo()
    {
        Application.LoadLevel(logoLevel);
    }
    public void Menu()
    {
        Application.LoadLevel(mainMenuLevel);
    }
    public void PlayGame()
    {
        Application.LoadLevel(gameplayLevel);
    }
    public void Options()
    {
        Application.LoadLevel(optionsLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
