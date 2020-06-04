using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Counter : MonoBehaviour {

	public int points;
	public GameObject pointCounter;
	public bool canvasCounter;
	public bool oldCounter;

	// Use this for initialization
	void Start () {
		canvasCounter = true;
		oldCounter = false;
		points = 0;
	}

	private void OnTriggerEnter(Collider other) {
		points++;
		Debug.Log("+1 puntos. Total: " + points);
		pointCounter.GetComponent<Text>().text = "Puntos: " + points;
	}

	private void Update() {
		if (canvasCounter)
			pointCounter.GetComponent<Text>().enabled = true;
		else 
			pointCounter.GetComponent<Text>().enabled = false;
	}

	private void OnGUI() {
		if (oldCounter)
			GUI.TextField(new Rect(Screen.width/2, 10, 100, 20),"Puntos: " + points.ToString());	
	}
}
