using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonaction : MonoBehaviour {

	public Button startButton;
	public Button inventoryButton;
	public Button exitButton;

	// Use this for initialization
	void Start () {


		Button btn = startButton.GetComponent<Button>();
		btn.onClick.AddListener(StartButtonPressed);

		Button btn1 = inventoryButton.GetComponent<Button>();
		btn1.onClick.AddListener(InventoryButtonPressed);

		Button btn2 = exitButton.GetComponent<Button>();
		btn2.onClick.AddListener(ExitButtonPressed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void StartButtonPressed(){
	   //
		SceneManager.LoadScene("Game");
	}

	void InventoryButtonPressed(){

		SceneManager.LoadScene ("Inventory");
	}

	public void ExitButtonPressed(){

		Application.Quit ();

	}

}
