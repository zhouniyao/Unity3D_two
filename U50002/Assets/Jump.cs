using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	protected float jump_speed = 10.0f;
	public bool is_landing = false;
	// Use this for initialization
	void Start () {
		this.is_landing = false;
	}

	// Update is called once per frame
	void Update () {
		if(this.is_landing){
			if(Input.GetMouseButtonDown(0)){//可以点击鼠标左键
				this.is_landing = false;
				GetComponent<Rigidbody>().velocity = Vector3.up * jump_speed;
				//Debug.Break ();//暂停游戏
			}
		}
	}

	void FixedUpdate(){
		
	}
	//添加和其他游戏对象发生碰撞时调用的方法
	void OnCollisionEnter(Collision collision){
		//if (collision.gameObject.tag == "floor") {
			this.is_landing = true;
		
	}
}
