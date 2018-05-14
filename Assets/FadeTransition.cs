using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FadeTransition : MonoBehaviour {

	public Image black;
	public Animator anim;

	// Use this for initialization
	void Start () {
		StartCoroutine(Fading());
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator Fading(){
		
		yield return new WaitForSeconds (5.3f);


		SceneManager.LoadScene ("Menu");
	}
}
