using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRepeat : MonoBehaviour {

	public float speeds=0.2f;
	public float sizeofsprite=20.0f;

	private Vector3 startPosition;
	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.Repeat (Time.time * speeds, sizeofsprite);
		transform.position = startPosition + Vector3.left * newPosition;
	}
}
