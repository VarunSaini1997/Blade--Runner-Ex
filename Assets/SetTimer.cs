using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimer : MonoBehaviour {

	public float maxtime = 5f;
	float timeleft;
	public float xtime;
	public Slider Progress;
	public GameObject defeatscreen;

	// Use this for initialization
	void Start () {
		
		timeleft = maxtime;
		defeatscreen.SetActive (false);
	}

	
	// Update is called once per frame
	void Update () {
		if (timeleft > 0) {

			timeleft -= Time.deltaTime;

			xtime = timeleft / maxtime;
			Progress.value = xtime;
		
		} else {
			defeatscreen.SetActive (true);
			Time.timeScale = 0;
			//end game;

		}
}
}