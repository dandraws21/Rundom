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
                Run();
                break;

            case PlayerState.Jump:
                Jump();
                break;

            case PlayerState.Dash:
                Dash();
                break;

            case PlayerState.Dead:
                Dead();
                break;

            default:
                break;
        }
    }

    #region UPDATE METHODS

    void Run()
    {

    }

    void Jump()
    {

    }

    void Dash()
    {

    }

    void Dead()
    {

    }

    #endregion

    #region STATE METHODS

    void RunState()
    {
        currentPlayerState = PlayerState.Run;
    }

    void JumpState()
    {
        currentPlayerState = PlayerState.Jump;
    }

    void DashState()
    {
        currentPlayerState = PlayerState.Dash;
    }

    void DeadState()
    {
        currentPlayerState = PlayerState.Dead;
    }

    #endregion
}
