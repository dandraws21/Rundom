using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public Transform islandsGenerator;
    public Transform cloudsGenerator;
    public Transform mountsGenerator;
    public Transform treeGenerator;
    
    private Vector3 islandsStartPoint;
    private Vector3 cloudsStartPoint;
    private Vector3 mountsStartPoint;
    private Vector3 treeStartPoint;

    public PlayerControlls thePlayer;
    private Vector3 playerStartPoint;

    private ObjectDestroyer[] platformList;

    private ScoreManager theScoreManager;

    public DeathMenu theDeathScreen;
    public GameObject pauseButton;
    

    // Use this for initialization
    void Start (){
        playerStartPoint = thePlayer.transform.position;
        platformStartPoint = platformGenerator.position;

        islandsStartPoint = islandsGenerator.position;
        cloudsStartPoint = cloudsGenerator.position;
        mountsStartPoint = mountsGenerator.position;
        treeStartPoint = treeGenerator.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
	}
	
	// Update is called once per frame
	void Update () {

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
        cloudsGenerator.position = cloudsStartPoint;
        mountsGenerator.position = mountsStartPoint;
        treeGenerator.position = treeStartPoint;

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
