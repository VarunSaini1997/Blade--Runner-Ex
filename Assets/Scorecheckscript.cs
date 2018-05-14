using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecheckscript : MonoBehaviour {

	public Text scoredisplay;
	public Text scoretotal;
	public float Scoore;
	private float highest;
	// Use this for initialization
	void Start () {
		highest = PlayerPrefs.GetInt ("highest",0);
		Scoore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void updatescore(float n){
		Scoore += n;
		Text tt=scoretotal.GetComponent<Text> ();
		tt.text = Scoore.ToString();
		tt=scoredisplay.GetComponent<Text> ();
		tt.text = Scoore.ToString ();
		if (highest < Scoore) {
			PlayerPrefs.SetInt ("highest",(int)Scoore );
		}

	}
}
