using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UGUIScrollbar : MonoBehaviour {
	public Scrollbar sb;
	public Text tt;
	public void OnSBChange(){
		tt.text = "" + sb.value;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
