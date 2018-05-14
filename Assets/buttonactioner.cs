using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class buttonactioner : MonoBehaviour {

	public Button restartButton;
	public Button menuButton;

	// Use this for initialization
	void Start () {

		Button btn = restartButton.GetComponent<Button>();
		btn.onClick.AddListener(RestartButton);

		Button btn1 = menuButton.GetComponent<Button>();
		btn1.onClick.AddListener(MenuButton);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void RestartButton(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	void MenuButton(){
		SceneManager.LoadScene("Menu");
	}
}
