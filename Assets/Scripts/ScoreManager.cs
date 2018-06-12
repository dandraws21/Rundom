using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text scoreDeathText;
    //public Text hiScoreText;
    public Text hiScoreDeathText;

    public Text distanceText;
    public Text distanceDeathText;

    public float scoreCount;
    public float hiScoreCount;
    public float distanceCount;

    public float pointsPerSecond;

    public bool scoreIncreasing = true;

    // Use this for initialization
    void Start () {

        distanceCount = 0;

        if(PlayerPrefs.HasKey("HighScore")) // Run Save data at game start
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        if(scoreIncreasing)
        {
            distanceCount += pointsPerSecond * Time.deltaTime;
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount); // Save HighScore
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        scoreDeathText.text = "Score: " + Mathf.Round (scoreCount);

        //hiScoreText.text = "HighScore: " + Mathf.Round (hiScoreCount);
        hiScoreDeathText.text = "HighScore: " + Mathf.Round(hiScoreCount);


        distanceText.text = "Distance: " + Mathf.Round (distanceCount);
        distanceDeathText.text = "Distance: " + Mathf.Round(distanceCount);

    }

    public void AddScore (int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
