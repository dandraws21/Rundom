using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeTiles : MonoBehaviour
{
    [SerializeField]
    List<Sprite> spriteList;
    SpriteRenderer[] spritesArray;

	void Start ()
    {
        spritesArray = this.gameObject.GetComponentsInChildren<SpriteRenderer>();
        Randomize();
	}
    
    public void Randomize()
    {
        for(int i = 0; i < spritesArray.Length; i++)
        {
            spritesArray[i].sprite = spriteList[Random.Range(0, spriteList.Count)];
        }
    }
}
