using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour {
	public EasyJoystick MyJoystick;
	public CharacterController controller;
	float RunSpeed;
	Vector3 MoveDrection;
	public GameObject CameraA;
	// Use this for initialization
	void Start () {
		
		controller.slopeLimit = 30f;
		RunSpeed = 1000;
	}
	
	// Update is called once per frame
	void Update () {
		MoveDrection = new Vector3(Input.GetAxis("Fire1"), 0, 0);
		MoveDrection = transform.TransformDirection(MoveDrection);//获取虚拟轴方向
		if (MyJoystick.JoystickTouch.y == 0 && MyJoystick.JoystickTouch.x == 0) {
			//GetComponent<Animation>().Play("Laugh");
		}
		if (MyJoystick.JoystickTouch.y > 0.5f) {
			//GetComponent<Animation>().Play("Run");    
		}
		if (MyJoystick.JoystickTouch.x < -0.5f)
		{
			this.transform.Rotate(0, -1.0f, 0);
		}
		if (MyJoystick.JoystickTouch.x > 0.5f)
		{
			this.transform.Rotate(0, 1.0f, 0);
		}
		if (MyJoystick.JoystickTouch.y < -0.5f)
		{
			CameraA.transform.Translate(Vector3.back);
		}
		//if(GetComponent<Animation>().IsPlaying("Run")){
		//	controller.SimpleMove(MoveDrection * (Time.deltaTime * RunSpeed));
		//}
	}
}
