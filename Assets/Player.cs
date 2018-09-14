using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public GameObject bowlingBall;

    public float ballDistance = 2.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        bowlingBall.transform.position = transform.position + transform.forward * ballDistance;
	}
}
