using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunBehaviourScript : MonoBehaviour {
	float angle;

	private Vector3 pos;
	public float flag1;
	public float flag2;


	//public GameObject bullet;
//	public float distance = 10;

	// Use this for initialization
	void Start () {
		pos = new Vector3 ();
		flag1 = 0;
		flag2 = 1;
		Input.multiTouchEnabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		
			
	foreach (Touch touch in Input.touches) {
			if (touch.position.x > Screen.width/2) {
				pos = touch.position;
				//send pos to runnerbulletfor aim bullet
				this.GetComponent<RunnerBulletScript> ().updatedirectionbullet (pos);
				flag1 = 1;
				//gundirection
	//	pos=Input.mousePosition;
				pos.z = -(transform.position.x - Camera.main.transform.position.x);
				Vector3 objpos = Camera.main.ScreenToWorldPoint (pos);
				pos.x = Mathf.Clamp (pos.x, 15f, 20f) - objpos.x;
				pos.y = Mathf.Clamp (pos.y, -7f, 6f) - objpos.y;
				angle = ((Mathf.Atan2 (pos.y, pos.x) * Mathf.Rad2Deg - 50));
				//angle2 = angle * 3;
				//angle2 = angle/2;
				transform.rotation = Quaternion.Euler (0, 0, -angle);


			} //else if (touch.position.x <  Screen.width/2 && touch.phase != TouchPhase.Ended && flag1==1) {

	//			if (flag2 == 1) {
	//				this.GetComponent<RunnerBulletScript> ().shoot ();
	//				flag2 = 0;
	//			}
	//		}
	//		if (touch.position.x < Screen.width / 2 && touch.phase == TouchPhase.Ended && flag2 == 0) {
	//			flag2 = 1;
	//		}

		}

			
	//GameObject projectile = (GameObject)Instantiate( bullet, pos, Quaternion.identity);
	}



}

