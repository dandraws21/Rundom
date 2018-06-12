using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoScreen : MonoBehaviour {

    private int TimeCounter;

    public string mainMenu;
    
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        TimeCounter += 1;

        if (TimeCounter == 300 || (Input.GetKey(KeyCode.Space)))
        {
            MainMenu();
        }
    }

    public void MainMenu()
    {
        Application.LoadLevel(mainMenu);
    }
}
