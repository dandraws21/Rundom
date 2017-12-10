using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Fields")]
    int lifes;
    float attackCooldown;
    float attackCounter;
    float speed;
    bool isDashing;

    PlayerState currentPlayerState;
    enum PlayerState
    {
        Run,
        Jump,
        Dash,
        Dead
    }

	void Start ()
    {
		
	}

	void Update ()
    {
        switch (currentPlayerState)
        {
            case PlayerState.Run:

                break;

            case PlayerState.Jump:

                break;

            case PlayerState.Dash:

                break;

            case PlayerState.Dead:

                break;

            default:
                break;
        }
    }
}
