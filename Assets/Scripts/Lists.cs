using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    List<GameObject> activePlatforms;
    List<GameObject> inactivePlatforms;

    void Start ()
    {
        inactivePlatforms = new List<GameObject>();
        foreach (GameObject platform in GameObject.FindGameObjectsWithTag("Platform"))
        {
            inactivePlatforms.Add(platform);
        }
        activePlatforms = new List<GameObject>();
    }


    public void ActivePlatform(GameObject platform)
    {
        if (!activePlatforms.Contains(platform))
        {
            inactivePlatforms.Remove(platform);
            activePlatforms.Add(platform);
        }
    }

    public void DesactivePlatform(GameObject platform)
    {
        if (!inactivePlatforms.Contains(platform))
        {
            activePlatforms.Remove(platform);
            inactivePlatforms.Add(platform);
        }
    }

    public GameObject PassInactivePlatform()
    {
        return inactivePlatforms[0];
    }

}
