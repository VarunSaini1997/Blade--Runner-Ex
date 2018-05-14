using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {

	public float damage = 100f;
	void Start(){

		StartCoroutine (deletebullet ());

	}

	IEnumerator deletebullet(){
		yield return new WaitForSeconds (2f);
	}

	public float getdamage(){
		return damage;
	}

	public void hit(){
		Destroy (gameObject);
	}
	void OnTriggerEnter2D(){
		Destroy (this.gameObject);
	}
}
