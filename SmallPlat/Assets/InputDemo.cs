using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDemo : MonoBehaviour {
	int keyframe = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/*
		if(Input.GetKeyDown(KeyCode.A)){
			Debug.Log("你按下了"+ "A");
		}
		if(Input.GetKeyDown(KeyCode.S)){
			Debug.Log("你按下了"+ "S");
		}
		if(Input.GetKeyDown(KeyCode.D)){
			Debug.Log("你按下了"+ "D");
		}
		if(Input.GetKeyDown(KeyCode.W)){
			Debug.Log("你按下了"+ "W");
		}

		if(Input.GetKeyUp(KeyCode.A)){
			Debug.Log("你抬起了"+ "A");
		}
		if(Input.GetKeyUp(KeyCode.S)){
			Debug.Log("你抬起了"+ "S");
		}
		if(Input.GetKeyUp(KeyCode.D)){
			Debug.Log("你抬起了"+ "D");
		}
		if(Input.GetKeyUp(KeyCode.W)){
			Debug.Log("你抬起了"+ "W");
		}

		if(Input.GetKeyDown(KeyCode.Space)){
			Debug.Log("你按了空格键一次");
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			Debug.Log ("你抬起了空格键一次");
		}
		if(Input.GetKey(KeyCode.Space)){
			keyframe++;
			Debug.Log("你长按空格键"+keyframe+"帧");
		}
		*/

		/*//鼠标输入事件
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("你按下了左键 " + Input.mousePosition);
		}
		if(Input.GetMouseButtonDown(1)){
			Debug.Log("你按下了右键 " + Input.mousePosition);
		}
		if(Input.GetMouseButtonDown(2)){
			Debug.Log("你按下了中间键 " + Input.mousePosition);
		}
		if(Input.GetMouseButtonUp(0)){
			Debug.Log("你抬起了左键 " + Input.mousePosition);
		}
		if(Input.GetMouseButtonUp(1)){
			Debug.Log("你抬起了右键 " + Input.mousePosition);
		}
		if(Input.GetMouseButtonUp(2)){
			Debug.Log("你抬起了中间键 " + Input.mousePosition);
		}
		if(Input.GetMouseButton(0)){
			Debug.Log("鼠标左键一直按下 " + Input.mousePosition);
		}
		if(Input.GetMouseButton(1)){
			Debug.Log("鼠标右键一直按下 " + Input.mousePosition);
		}
		if(Input.GetMouseButton(2)){
			Debug.Log("鼠标中间键一直按下 " + Input.mousePosition);
		}
		*/
		//自定义按键
		if(Input.GetButtonDown("test")){
			Debug.Log ("自定义按键Test按下");
		}
		if(Input.GetButtonUp("test")){
			Debug.Log ("自定义按键Test抬起");
		}
		if(Input.GetButton("test")){
			Debug.Log ("长按自定义按键Test");
		}
		float value = Input.GetAxis ("test");
		Debug.Log ("按键的数值为： " + value);
	}
}
