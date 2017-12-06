using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour {
	public GameObject ball;
	private float lastDis = 0;//上一次两个手指的距离
	private float cameraDis = -20;//摄像机距离球
	public float ScaleDump = 0.1f;//阻尼系数
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1) {
			Touch t = Input.GetTouch (0);//获取首个触控位置
			if (t.phase == TouchPhase.Moved) {
				//ball.transform.Rotate (Vector3.right, Input.GetAxis ("Mouse Y"), Space.World);//竖直旋转
				//ball.transform.Rotate (Vector3.up, -1 * Input.GetAxis ("Mouse X"), Space.World);//水平旋转
				ball.transform.Rotate (Vector3.right, t.deltaPosition.x, Space.World);//竖直旋转
				ball.transform.Rotate (Vector3.up, -1 * t.deltaPosition.y, Space.World);//水平旋转
			}
		} else if (Input.touchCount > 1) {
			Touch t1 = Input.GetTouch (0);
			Touch t2 = Input.GetTouch (1);
			if (t2.phase == TouchPhase.Began) {//开始触控
				lastDis = Vector2.Distance(t1.position, t2.position);//初始化lastDis
			}else{
				if (t1.phase == TouchPhase.Moved && t2.phase == TouchPhase.Moved) {//两手指都在移动
					float dis = Vector2.Distance (t1.position, t2.position);//计算手指位置
					if(Mathf.Abs(dis - lastDis)>1){//手指位置大于1
						cameraDis += (dis - lastDis) * ScaleDump;//设置摄像机到物体的距离
						cameraDis = Mathf.Clamp(cameraDis, -40, -5);//限制摄像机到物体距离
						lastDis = dis;
					}
				}
			}
		}
	}

	void LateUpdate(){
		this.transform.position = new Vector3 (0, 0, cameraDis);//调整摄像机位置

	}
	void OnGUI(){
		string s = string.Format ("Input.touchCount={0}\n cameraDis=\n{1}", Input.touchCount, cameraDis);
		GUI.TextArea (new Rect (0, 0, Screen.width / 10, Screen.height), s);//text显示字符
		if (GUI.Button (new Rect (Screen.width * 9 / 10, 0, Screen.width / 10, Screen.height / 10), "quit")) {//退出按钮
			Debug.Log ("quit");
			Application.Quit ();
		}
	}
}
