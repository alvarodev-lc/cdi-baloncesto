using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour {

	private float width;
	private float heigth;

	// Use this for initialization
	void Start () {
		heigth = 2f * gameObject.GetComponent<Camera>().orthographicSize;
		width = gameObject.GetComponent<Camera>().aspect * heigth;
		Debug.Log(width);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
