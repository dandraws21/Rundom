using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour {
    
    public int TimeCount;
    public int Timer;
    public float maxDistance;
    public float initialPos;

    public float speed;
    public float totalTime;

    // Use this for initialization
    void Start () {

        TimeCount = 0;
        Timer = 0;

        initialPos = -50;
        maxDistance = 50;

        totalTime = 1200;

        speed = (maxDistance - initialPos) / totalTime;

    }
	
	// Update is called once per frame
	void Update () {

        TimeCount += 1;
        if (TimeCount == 60)
        {
            TimeCount = 0;
            Timer += 1;
        }

        if (Timer < 100)
        {
            transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        }

    }
}
