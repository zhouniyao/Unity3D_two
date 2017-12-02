using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterfly_gen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//this.GetComponent<Rigidbody> ().velocity = new Vector3 (Random.Range (-3f, 6f), Random.Range (3f, 6f), Random.Range (-3f, 6f));
		this.GetComponent<Rigidbody> ().velocity = new Vector3 (8, 15, Random.Range (-10f, 6f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnBecameInvisible(){
		Destroy (this.gameObject);
	}
}
