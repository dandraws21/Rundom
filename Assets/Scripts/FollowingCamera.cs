using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    [SerializeField]
    float offsetX;
    GameObject player;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate ()
    {
        this.transform.position = new Vector3(player.transform.position.x + offsetX, this.transform.position.y, this.transform.position.z);
    }

}
