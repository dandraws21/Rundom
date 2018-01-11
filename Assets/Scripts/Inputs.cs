using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs : MonoBehaviour
{
    Player player;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            player.Jump();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            player.BeginDash();
        }
    }
}
