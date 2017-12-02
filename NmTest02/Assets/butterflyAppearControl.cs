using UnityEngine;
using System.Collections;

public class butterflyAppearControl : MonoBehaviour {

	// 小球的预设
	// 通过检视器设置具体值
	public GameObject	ballPrefab;
	GameObject rock;
	int count;

	// Use this for initialization
	void Start () {
		rock = GameObject.Find ("Rock_01_a");
		count = 0;
		//position = new Vector3 (rock.GetComponent<Transform> ().position.x, rock.GetComponent<Transform> ().position.y,rock.GetComponent<Transform> ().position.z);
	}

	// Update is called once per frame
	void Update () {

		// 距离小到一定程度，蝴蝶飞舞
		if(transform.position.x - rock.GetComponent<Transform>().position.x < 15f && count < 1) {

			// 实例化小球的预设（生成游戏对象）
			Instantiate(this.ballPrefab, rock.GetComponent<Transform> ());
			count++;
		}	
	}
}
