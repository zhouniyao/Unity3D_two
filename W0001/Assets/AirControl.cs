using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirControl : MonoBehaviour {
	private Transform m_transform;//Transform组件
	public float speed = 600f;
	private float rotationz = 0.0f;//绕z轴的旋转量
	public float rotateSpeed_AxisZ = 45f;//绕z轴的旋转速度
	public float rotateSpeed_AxisY = 20f;//绕y轴的旋转速度
	private Vector2 touchPosition;//触摸点坐标
	private float screenWeight;//屏幕宽度


	// Use this for initialization
	void Start () {
		m_transform = this.transform;//保持this.transform调用，避免Update()中多次调用游戏对象上Transform组件
		this.gameObject.GetComponent<Rigidbody> ().useGravity = false;//关闭重力
		screenWeight = Screen.width;//获得屏幕宽度
	}
	
	// Update is called once per frame
	void Update () {
		m_transform.Translate (new Vector3 (0, 0, speed * Time.deltaTime));//向前
		//寻找到名称为***的对象并使其绕Y轴旋转。[螺旋桨旋转起来]
		GameObject.Find("AircraftWingsPropellerBlurLeft").transform.Rotate(new Vector3(0, 0, 1000f * Time.deltaTime));
		GameObject.Find("AircraftWingsPropellerBlurRight").transform.Rotate(new Vector3(0, 0, 1000f * Time.deltaTime));

		//控制飞机左右转向，触控左边左转，触控右边右转，不触控恢复平衡状态
		rotationz = this.transform.eulerAngles.z;//获取飞机对象绕z轴的旋转量
		if(Input.touchCount >0){	//当触摸的数量大于0
			for (int i = 0; i < Input.touchCount; i++) {
				Touch touch = Input.touches [i];//实例化当前触摸点
				//当手机在屏幕上没有移动或发生滑动时触发事件
				if(touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved){
					//获取当前触摸点坐标
					touchPosition = touch.position;
					//触摸点在屏幕左半侧
					if(touchPosition.x < screenWeight /2 ){
						if((rotationz <= 45 || rotationz >= 135)){
							//飞机左倾斜
							m_transform.Rotate(new Vector3(0, 0, (Time.deltaTime * rotateSpeed_AxisZ)), Space.Self);//绕自身坐标系旋转
						}
						//飞机左转
						m_transform.Rotate(new Vector3(0, -Time.deltaTime*30, 0), Space.World);
					}
					else if(touchPosition.x >= screenWeight/2){
						if((rotationz <= 45 || rotationz >= 135)){
							//飞机右倾斜
							m_transform.Rotate(new Vector3(0, 0, -(Time.deltaTime * rotateSpeed_AxisZ)), Space.Self);//绕自身坐标系旋转
						}
						//飞机右转
						m_transform.Rotate(new Vector3(0, Time.deltaTime*30, 0), Space.World);
					}
				}
				else if(touch.phase == TouchPhase.Ended){
					BackToBlance();//恢复平衡
				}
			}
		}
		if(Input.touchCount == 0){//无触控
			BackToBlance();
		}
		//判断当前运行的平台为Android
		if(Application.platform == RuntimePlatform.Android){
			if (Input.GetKeyDown (KeyCode.Home)) {//Home建是否按下
				Application.Quit();//退出程序
			}
			if (Input.GetKeyDown (KeyCode.Escape)) {
				
			}
		}
	}
	//无转向时，恢复平衡状态
	void BackToBlance(){
		if ((rotationz <= 180)) {//判断如果飞机为右倾状态
			if (rotationz - 0 <= 2) {
				m_transform.Rotate (0, 0, Time.deltaTime * -1);//在阀值内轻微晃动
			} else {
				m_transform.Rotate (0, 0, Time.deltaTime * -40);//快速恢复平衡状态
			}
		}
		if ((rotationz >= 180)) {//判断如果飞机为左倾状态
			if (360 - rotationz <= 2) {
				m_transform.Rotate (0, 0, Time.deltaTime * 1);//在阀值内轻微晃动
			} else {
				m_transform.Rotate (0, 0, Time.deltaTime * 40);//快速恢复平衡状态
			}
		}
	}
}
