using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionDemo : MonoBehaviour {
	private bool isRotation = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isRotation) {
			
			gameObject.transform.rotation = Quaternion.Slerp (gameObject.transform.rotation, 
															Quaternion.Euler (0f, 50f, 0f), 
															Time.time * 0.1f);
			isRotation = false;
		}
	}
	void OnGUI(){
		//以当前角度为初始角度，在一定时间内旋转到设定的角度
		if(GUILayout.Button("旋转固定角度", GUILayout.Height(50))){
			gameObject.transform.rotation =Quaternion.Euler(0f, 50f, 0f);
		}
		if (GUILayout.Button ("插值旋转固定角度", GUILayout.Height (50))) {
			isRotation = true;
		}
	}
}
