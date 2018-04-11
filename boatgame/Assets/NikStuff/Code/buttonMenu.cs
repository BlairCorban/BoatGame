using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttonMenu : MonoBehaviour {
	//public Button MainButton;
	//public Button ControlsButton;
	//public Button ExitButton;

	// Use this for initialization
	void Start () {
        //public Button yourButton;
        //Cursor.visible = false;


       


  //      Button MB = MainButton.GetComponent<Button>();
		//Button CB = ControlsButton.GetComponent<Button>();
		//Button EB = ExitButton.GetComponent<Button>();

		//MB.onClick.AddListener(MainMenu);
		//CB.onClick.AddListener(ControlButton);
		//EB.onClick.AddListener(Exit);
	} 

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("AButton") == true)
        {
            Debug.Log("a");
            MainMenu();
        }
        if (Input.GetButtonDown("YButton") == true)
        {
            Debug.Log("a");
            ControlButton();
        }
        if (Input.GetButtonDown("BButton") == true)
        {
            //Debug.Log("a");
            Application.Quit();
        }
    }

	void MainMenu()
	{
		//Debug.Log("load main");
		SceneManager.LoadScene("Sence1");
	}
	void ControlButton()
	{
		//Debug.Log("load main");
		SceneManager.LoadScene("Controls");
	}
	void Exit()
	{
		//Debug.Log("Quit");
		Application.Quit();
	}
}

