using UnityEngine;
using System.Collections;
//湖面，随水流产生的波动
public class Shake : MonoBehaviour {
    float RotSpeedX=0.04f;
    float RotSpeedZ=0.06f;
    float ShakeFactor = 4;//声明旋转中心面
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if (transform.eulerAngles.x >= ShakeFactor && transform.eulerAngles.x <= 180)//x轴旋转最大限度
            {
                RotSpeedX = -0.04f;//定义旋转速度
            }
        if (transform.eulerAngles.x <= 360 - ShakeFactor && transform.eulerAngles.x > 180)//x轴旋转最小限度
            {
                RotSpeedX = 0.04f;//定义旋转速度
            }
        if (transform.eulerAngles.z >= ShakeFactor && transform.eulerAngles.z <= 180)//z轴旋转最大限度
            {
                RotSpeedZ = -0.06f;
            }
        if (transform.eulerAngles.z <= 360 - ShakeFactor && transform.eulerAngles.z > 180)//z轴旋转最小限度
            {
                RotSpeedZ = 0.06f;
            }
            transform.Rotate(RotSpeedX, 0, RotSpeedZ);
	}
}
