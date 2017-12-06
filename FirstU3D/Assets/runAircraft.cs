using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class runAircraft : MonoBehaviour {
    private Animator animator;
    public float DirectionDampTime = 0.25f;
	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();//获得一个Animator类型的组件

	}
	
	// Update is called once per frame
	void Update () {
        if (animator) { //判断是否获得Animator组件
            float horizontal = Input.GetAxis("Horizontal");//获得水平轴的虚拟坐标值
            /**
             * SetFloat是Animator的一个方法，该方法可将参数horizontal的值赋给Direction这个ID，
             * 从而在动画编辑器中Direction变量便可获得交互改变，以便实现对角色左右跑的控制。
             * DirectionDampTime为允许参数到达值的时间，Time.deltaTime表示以帧为单位的时间，它是从最近一次调用Update或者FixedUpdate方法到现在的时间。
             */
            animator.SetFloat("Direction", horizontal, DirectionDampTime, Time.deltaTime);
        }
	}
}
