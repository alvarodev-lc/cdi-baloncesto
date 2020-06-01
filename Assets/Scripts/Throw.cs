using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour {

	public GameObject ballPrefab;
	
	// Update is called once per frame
	void Update () {

		bool cKey = Input.GetKeyDown (KeyCode.C);
		bool spaceKey = Input.GetKeyDown (KeyCode.Space);

		if (cKey || spaceKey){

			GameObject ball = Instantiate(ballPrefab, transform.position, transform.rotation);
			Vector3 force = new Vector3();

			if (cKey) {
				force = new Vector3(0f, 13.5f, -10f);
			}

			if (spaceKey) {
				force = new Vector3(Random.Range(-1.5f,1.5f), Random.Range(13.5f, 14f), Random.Range(-10f, -11.5f));
			}

			ball.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
			Destroy(ball, 10f);
		}
		
	}
}
