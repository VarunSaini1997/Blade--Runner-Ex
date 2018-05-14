using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoomEShootScript : MonoBehaviour {

	public GameObject enemyBullet;
	public float health = 150f;
	public float enemybulletspeed = 5f;
	public float shootPerSecond = 1.8f;
	public GameObject Scorewriter;

/*	private ScoreScript scoreScript;

	static AudioSource BulletImpact;
*/
	void Start(){
		Scorewriter = GameObject.FindWithTag ("scores");
	}

	void Update(){
		float probability = Time.deltaTime * shootPerSecond;
		//print ("Delta time=" + Time.deltaTime);
		if (Random.value < probability) {
			attack ();
		}

	}

	void attack(){
		Vector3 startPosition = transform.position + new Vector3 (-2, -0.5f, 0);
		GameObject bullet = Instantiate (enemyBullet, startPosition, Quaternion.identity) as GameObject;
		bullet.GetComponent<Rigidbody2D> ().velocity = new Vector2 (-enemybulletspeed,0);
	}

	void OnTriggerEnter2D(Collider2D collider){

		if (collider.gameObject.tag == "PlayerBullet") {
			health -= 50;
			if (health <= 0) {
				Scorewriter.GetComponent<Scorecheckscript> ().updatescore(1f);

				//BulletImpact = GetComponent<AudioSource> ();
				//BulletImpact.Play ();
				Destroy (this.gameObject);
			}
		}
		//}

	}

}
