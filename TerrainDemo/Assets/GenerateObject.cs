using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onGUI(){
		if (GUILayout.Button ("CreateCube", GUILayout.Height (50))) {
			GameObject m_cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			m_cube.AddComponent<Renderer>();
			m_cube.GetComponent<Renderer> ().material.color = Color.blue;
			m_cube.transform.position = new Vector3 (100, 10, 30);
		}
		if (GUILayout.Button ("CreateSphere", GUILayout.Height (50))) {
			GameObject m_cube = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			m_cube.AddComponent<Renderer>();
			m_cube.GetComponent<Renderer> ().material.color = Color.green;
			m_cube.transform.position = new Vector3 (100, 10, 50);
		}
	}
}
