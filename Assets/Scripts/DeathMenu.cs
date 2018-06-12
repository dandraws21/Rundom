    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenu : MonoBehaviour {

    public string mainMenuLevel;

    private AudioSource clickSound;

    void Start()
    {
        clickSound = GameObject.Find("ClickSound").GetComponent<AudioSource>();
    }

    public void RestartGame()
    {
        FindObjectOfType<GameManager>().Reset();

        clickSound.Play();
    }
    public void QuitToMain()
    {
        Application.LoadLevel(mainMenuLevel);

        clickSound.Play();
    }

}
