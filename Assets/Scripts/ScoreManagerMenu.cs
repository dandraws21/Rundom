using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerMenu : MonoBehaviour {

    public Text hiScoreText;

    public float hiScoreCount;
    

    // Use this for initialization
    void Start () {
        if(PlayerPrefs.HasKey("HighScore")) // Run Save data at game start
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        hiScoreText.text = "HighScore: " + Mathf.Round(hiScoreCount);

        /*if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount); // Save HighScore
        }

        scoreText.text = "Score: " + Mathf.Round (scoreCount);
        scoreDeathText.text = "Score: " + Mathf.Round (scoreCount);

        hiScoreDeathText.text = "HighScore: " + Mathf.Round (hiScoreCount);*/
    }
}
