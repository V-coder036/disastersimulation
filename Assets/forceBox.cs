using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceBox : MonoBehaviour {
	public float speed;
	public static int x;
	// Use this for initialization
	void Start () {
		speed = 5f;
		x = 0;
	}

	
	// Update is called once per frame
	void Update () {
		if (x % 2 == 0)
			transform.Translate (speed * Time.deltaTime, 0f, 0f);
		else
			transform.Translate (-(speed * Time.deltaTime), 0f, 0f);
	}
}
