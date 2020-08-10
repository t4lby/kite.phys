using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody>().AddForce(0.2f, 0f, 0.1f);
	}
}
