using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayerBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (DesPayBull ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D collider){
		Destroy (gameObject);

	}
	IEnumerator DesPayBull(){
		yield return new WaitForSeconds (3f);
		Destroy (gameObject);
	}

}
