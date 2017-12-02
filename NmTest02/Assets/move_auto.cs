using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_auto : MonoBehaviour {
	public float visitSpeed = 30f;
	public float RotSpeed = 1f;
	//Vector3 dir = Vector3.zero;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		float x = Input.acceleration.x;
		//float z = -(Input.acceleration.y); 
		float z = -(Input.acceleration.y + 0.6f);
		if (z < -0.2)
			z = -1;
		if (z > 0.1f)
			z = 1;
		//x *= Time.deltaTime;
		z *= Time.deltaTime;
		if(x > 0.1)
			transform.Rotate (0, RotSpeed, 0);
		if(x<-0.1)
			transform.Rotate (0, -RotSpeed, 0);
		transform.Translate (0f, 0f , z * visitSpeed/6);
		//transform.Translate(0, 0, visitSpeed);
	}
}
