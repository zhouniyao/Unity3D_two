using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestYield : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Test ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	IEnumerator Test(){
		Debug.Log ("开始时间" + Time.time);
		yield return new WaitForSeconds (2);
		Debug.Log ("结束时间" + Time.time);
	}
}
