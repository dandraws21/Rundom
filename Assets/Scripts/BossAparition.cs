using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAparition : MonoBehaviour {
    
    public int Stage;

    private ScoreManager theScoreManager;

    public float moveSpeed;
    private Rigidbody2D myRigidbody;


    // Use this for initialization
    void Start () {
        
        Stage = 0;

        theScoreManager = FindObjectOfType<ScoreManager>();

        moveSpeed = 10;
        myRigidbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (theScoreManager.distanceCount == 20 && Stage == 0) // First Sounds
        {
            myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
            Stage = 1;
        }
        if (theScoreManager.distanceCount == 120 && Stage == 1) // BackAppearing
        {
            Stage = 2;

        }
        if (theScoreManager.distanceCount == 240 && Stage == 2) // Appears
        {
            Stage = 3;

        }
    }
}
