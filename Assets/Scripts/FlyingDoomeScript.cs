using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingDoomeScript : MonoBehaviour {

	public int flying;
	public float walkspeed=4f;
	public float counter;

	// Use this for initialization
	void Start () {
		flying = 1;
		counter = 0;

	}
	
	// Update is called once per frame
	void Update () {
		flyingdirection ();
		transform.Translate (Vector3.left * walkspeed * Time.deltaTime);

		if (flying == 1) {
			transform.Translate (Vector3.up * walkspeed * Time.deltaTime);

		} else if (flying == 2) {
			transform.Translate (Vector3.down * walkspeed * Time.deltaTime);
		
		}

	}

	void flyingdirection(){
		
			
		if (counter < 60 && counter > 0) {
			counter += 1;
			flying = 1;	
		} else if (counter >= 60) {
			flying = 2;				
			counter -= 120;
		} else if (counter <= 0) {
			counter += 1;
		}
		

	}
}
