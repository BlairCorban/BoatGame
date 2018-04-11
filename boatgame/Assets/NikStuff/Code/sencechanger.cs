using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sencechanger : MonoBehaviour {
	public Button NewSceneButton;
	// Use this for initialization
	void Start () {
		Button NSB = NewSceneButton.GetComponent<Button>();
		NSB.onClick.AddListener(NewSence);
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("load main");
        if (Input.GetButtonDown("AButton") == true)
        {
            //Debug.Log("a");
            NewSence();
        }
    }
	void NewSence()
	{
		Debug.Log ("load main");
		//SceneManager.LoadScene("MainMenu");


		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
		

	}
}
