using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadomDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int a = Random.Range (0, 100);
		float b = Random.Range (0f, 10f);
		Debug.Log ("随机整数" + a);
		Debug.Log ("随机浮点数" + b);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
