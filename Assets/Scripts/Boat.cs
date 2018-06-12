using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);

	}
}
