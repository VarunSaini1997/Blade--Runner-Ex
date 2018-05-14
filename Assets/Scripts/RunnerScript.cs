using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RunnerScript : MonoBehaviour {
	public float health=199f;
	public GameObject gun;
	public float currenthealth=0f;
	public Slider healthslider;
	public GameObject defeatscreen;

	void Start(){
		currenthealth = health;
		defeatscreen.SetActive (false);
	}
	void OnTriggerEnter2D(Collider2D collider){
		BulletScript bullet = collider.gameObject.GetComponent<BulletScript> ();

		healthslider.value = currenthealth;

		if (bullet) {
			currenthealth -= 2;
			health -= bullet.getdamage ();
			//health -= 30;
			bullet.hit ();
			Handheld.Vibrate();
			healthslider.value = currenthealth;

			if (currenthealth <= 0) {
				GetComponent<Animator> ().SetBool ("deadBool", true);
				GetComponent<Animator> ().SetTrigger ("deadTrigger");
				DestroyObject (gameObject, 3.0f);
				DestroyObject (gun, 0.2f);
				StartCoroutine(DefeatScreen());
			}

		}

	}

	IEnumerator DefeatScreen(){
		yield return new WaitForSeconds (1.5f);
		defeatscreen.SetActive (true);
	}


}
