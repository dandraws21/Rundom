using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaivour : MonoBehaviour {

    public int TimeCount;
    public int Timer;


    // Use this for initialization
    void Start()
    {

        TimeCount = 0;
        Timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

        TimeCount += 1;
        if (TimeCount == 60)
        {
            TimeCount = 0;
            Timer += 1;
        }


        if (Timer >= 120) // Appears
        {

        }
    }
}
