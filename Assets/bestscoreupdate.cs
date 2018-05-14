using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestscoreupdate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int x=PlayerPrefs.GetInt("highest", 0);
		this.GetComponent<Text> ().text = x.ToString ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
