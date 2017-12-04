using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class UGUIText : MonoBehaviour {
	public Text tt;
	// Use this for initialization
	void Start () {

		tt.color = Color.red;
		tt.text = "原来可以写中文";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
