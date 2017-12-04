using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UGUISlider : MonoBehaviour {
	public Slider sd;
	public Text tt;
	public void OnsdValueChange(){
		tt.text = "" + sd.value;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
