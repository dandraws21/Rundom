using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    List<GameObject> activePlatforms;
    List<GameObject> inactivePlatforms;

    GameObject player;
    float playerX;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update ()
    {
        playerX = player.transform.position.x;
	}
}
