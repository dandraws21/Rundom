using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing = true;

    // Use this for initialization
    void Start () {
        if(PlayerPrefs.HasKey("HighScore")) // Run Save data at game start
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount); // Save HighScore
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        hiScoreText.text = "HighScore: " + Mathf.Round (hiScoreCount);

    }

    public void AddScore (int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
