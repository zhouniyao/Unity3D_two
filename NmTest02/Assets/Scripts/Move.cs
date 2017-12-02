using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public EasyJoystick MyJoystick;//声明遥杆
    float MoveSpeed = 0.1f;//移动速度
    float RotSpeed = 1f;//旋转速度
    public GameObject WaterB;//WaterB尾部水花
    // Use this for initialization
    void Start()
    {
        WaterB.SetActive(false);//尾部水花不可见
    }

    // Update is called once per frame
    void Update()
    {
        if (MyJoystick.JoystickTouch.x > 0.5f) {//遥杆到右半部
            transform.Rotate(0, RotSpeed, 0);//赛艇向右旋转
            Circle.addSpeed = true;//螺旋桨加速
            
        }
        if (MyJoystick.JoystickTouch.x < -0.5f)//遥杆到左半部
        {
            transform.Rotate(0, -RotSpeed, 0);//赛艇向左旋转
            Circle.addSpeed = true;//螺旋桨加速
        }
        if (MyJoystick.JoystickTouch.y > 0.5f)//遥杆到上半部
        {
            WaterB.SetActive(true);//尾部水花可见
            transform.Translate(0, 0, MoveSpeed);//赛艇向前移动
            Circle.addSpeed = true;//螺旋桨加速
        }
        if (MyJoystick.JoystickTouch.y < -0.5f)//遥杆到下半部
        {
            transform.Translate(0, 0, -MoveSpeed); //赛艇向后移动
            Circle.addSpeed = true;//螺旋桨加速
        }
        if (MyJoystick.JoystickTouch.x == 0 && MyJoystick.JoystickTouch.y==0)//遥杆未动
        {
            WaterB.SetActive(false);//水花不可见
            Circle.minusSpeed = true;//螺旋桨减速
        }
    }
}
