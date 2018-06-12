using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public Transform islandsGenerator;
    public Transform boatsGenerator;
    public Transform cloudsGenerator;
    public Transform mountsGenerator;
    public Transform btreeGenerator;
    public Transform treeGenerator;
    public Transform grassGenerator; 

    private Vector3 islandsStartPoint;
    private Vector3 boatsStartPoint;
    private Vector3 cloudsStartPoint;
    private Vector3 mountsStartPoint;
    private Vector3 btreeStartPoint;
    private Vector3 treeStartPoint;
    private Vector3 grassStartPoint;

    public PlayerControlls thePlayer;
    private Vector3 playerStartPoint;

    private ObjectDestroyer[] platformList;

    private ScoreManager theScoreManager;

    public DeathMenu theDeathScreen;
    public GameObject thePauseMenu;
    public GameObject pauseButton;

    //Pause Game
    public string mainMenuLevel;

    //God Mode
    private bool GM;
    public GameObject theCatcher;
    public GameObject theDestroyer;


    // Use this for initialization
    void Start (){
        playerStartPoint = thePlayer.transform.position;
        platformStartPoint = platformGenerator.position;

        islandsStartPoint = islandsGenerator.position;
        boatsStartPoint = boatsGenerator.position;
        cloudsStartPoint = cloudsGenerator.position;
        mountsStartPoint = mountsGenerator.position;
        btreeStartPoint = btreeGenerator.position;
        treeStartPoint = treeGenerator.position;
        grassStartPoint = grassGenerator.position;
        grassStartPoint = grassGenerator.position;

        theScoreManager = FindObjectOfType<ScoreManager>();

        GM = false;
        theCatcher.gameObject.SetActive(false);
        theDestroyer.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update () {
        if ((Input.GetKey(KeyCode.R))) // Restart the game
        {
            Reset();
        }

        if ((Input.GetKey(KeyCode.G)))// Activate GODMODE 
        {
            if(GM == false) //Activate
            {
                theCatcher.gameObject.SetActive(true);
                theDestroyer.gameObject.SetActive(false);
                GM = true;
            } else
            {
                theCatcher.gameObject.SetActive(false);
                theDestroyer.gameObject.SetActive(true);
                GM = false;
            }
        }

        if ((Input.GetKey(KeyCode.P))) // Pause the game
        {
            thePauseMenu.SetActive(true);
            Time.timeScale = 0f;
            pauseButton.SetActive(false);
        }
    }

    public void RestartGame()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);

        theDeathScreen.gameObject.SetActive(true);
        pauseButton.SetActive(false);
        
        //StartCoroutine("RestartGameCo");
    }

    public void Reset()
    {
        theDeathScreen.gameObject.SetActive(false);
        platformList = FindObjectsOfType<ObjectDestroyer>();

        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }
        
        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        islandsGenerator.position = islandsStartPoint;
        boatsGenerator.position = boatsStartPoint;
        cloudsGenerator.position = cloudsStartPoint;
        mountsGenerator.position = mountsStartPoint;
        btreeGenerator.position = btreeStartPoint;
        treeGenerator.position = treeStartPoint;
        grassGenerator.position = grassStartPoint;

        pauseButton.SetActive(true);
        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }

    /*public IEnumerator RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        platformList = FindObjectsOfType<ObjectDestroyer>();

        for(int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        islandsGenerator.position = islandsStartPoint;
        cloudsGenerator.position = cloudsStartPoint;
        mountsGenerator.position = mountsStartPoint;
        treeGenerator.position = treeStartPoint;

        thePlayer.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }*/

}
