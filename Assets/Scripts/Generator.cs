using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    [SerializeField]
    GameObject platformGenerationPoint;
    GameObject player;
    [SerializeField]
    float offsetX;
    public bool active;
    Lists lists;

    void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        platformGenerationPoint = GameObject.FindGameObjectWithTag("PlatformGenerationPoint");
        lists = GetComponentInParent<Lists>();
    }

    void LateUpdate()
    {
        this.transform.position = new Vector2(player.transform.position.x + offsetX, this.transform.position.y);
    }

    private void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.gameObject.tag == "Platform")
        {
            if (active)
            {
                GameObject platform;
                platform = lists.PassInactivePlatform();

                platform.transform.position = platformGenerationPoint.transform.position;
                platform.GetComponent<RandomizeTiles>().Randomize();
                lists.ActivePlatform(platform);
            }
            else
            {
                lists.DesactivePlatform(hit.gameObject);
            }
        }
    }

}
