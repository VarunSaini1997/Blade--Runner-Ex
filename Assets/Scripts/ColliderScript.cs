using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour {
	
	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "PlayerBullet") {		
			DestroyObject (collision.gameObject);
		}else if (collision.gameObject.tag == "DoomeBullet") {		
			DestroyObject (collision.gameObject);
		}
	}

}