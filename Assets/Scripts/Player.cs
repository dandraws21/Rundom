using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Player Fields")]
    int lifes;
    float attackCooldown;
    float attackCounter;
    float speed = 1;
    float dashSpeed = 3;
    float dashCooldown = 0.7f;
    float dashDuration = 0.5f;
    float dashCounter = 0;
    float jumpForce = 20;
    public bool isGrounded;
    Rigidbody2D rb;
    [SerializeField]
    BoxCollider2D myCollider;

    [SerializeField]
    PlayerState currentPlayerState;
    enum PlayerState
    {
        Run,
        Dash,
        Dead,
    }

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}

	void Update ()
    {
        switch (currentPlayerState)
        {
            case PlayerState.Run:
                Run();
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
        Vector3 provisionalPos;

        provisionalPos = this.transform.position;
        provisionalPos.x += speed * Time.deltaTime;

        this.transform.position = provisionalPos;
    }

    void Dash()
    {
        Vector3 provisionalPos;

        provisionalPos = this.transform.position;
        provisionalPos.x += dashSpeed * Time.deltaTime;

        this.transform.position = provisionalPos;

        dashCounter += Time.deltaTime;

        if(dashCounter >= dashDuration)
        {
            dashCounter = 0;

            myCollider.size = new Vector3(2, 2, 0);
            myCollider.offset = new Vector3(0, 1, 0);

            RunState();
        }
    }

    void Dead()
    {

    }

    #endregion

    #region MECHANICS METHODS

    public void Jump()
    {
        if(isGrounded)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    public void BeginDash()
    {
        if(isGrounded)
        {
            myCollider.size = new Vector3(2, 1, 0);
            myCollider.offset = new Vector3(0, 0.5f, 0);

            DashState();
        }
    }

    #endregion

    #region STATE METHODS

    public void RunState()
    {
        currentPlayerState = PlayerState.Run;
    }

    public void DashState()
    {
        currentPlayerState = PlayerState.Dash;
    }

    public void DeadState()
    {
        currentPlayerState = PlayerState.Dead;
    }

    #endregion

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == ("Platform"))
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == ("Platform"))
        {
            isGrounded = false;
        }
    }

    #region DRAW GIZMOS

    private void OnDrawGizmosSelected()
    {
        //Gizmos.color = Color.red;
        //Vector3 pos = this.transform.position + (Vector3)groundBoxPos;
        //Gizmos.DrawWireCube(pos, groundBoxSize);
    }

    #endregion
}
