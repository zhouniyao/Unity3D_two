using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody>().velocity = new Vector3 (-6.0f, 10.0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
	
}
