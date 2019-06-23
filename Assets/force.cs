using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class force : MonoBehaviour {
	public float speed;
	Vector3 pos;
	public static int x;
	// Use this for initialization
	void Start () {
		speed = 3f;
		x = 0;
		pos = transform.position;
	}


	// Update is called once per frame
	void FixedUpdate () {
		if (x % 2 == 0) {
			transform.Translate (speed* Time.deltaTime, 0f, 0f);
			//transform.position = pos;
		}

		else{
			transform.Translate (-(speed * 2* Time.deltaTime), 0f, 0f);
			transform.position = pos;
		}
		x++;
	}
}
