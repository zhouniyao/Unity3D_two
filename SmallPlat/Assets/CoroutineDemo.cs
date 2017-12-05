using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDemo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (Test01());
	}
	IEnumerator Test01(){
		yield return new WaitForSeconds (5);
		Debug.Log ("游戏结束");
	}
}
