using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannoncontroller : MonoBehaviour {
    public GameObject ball;
    public bool canShoot;
	// Use this for initialization
	void Start () {
        canShoot = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("AButton"))
        {
            if(canShoot)
            {
                Instantiate(ball, transform.position, transform.rotation);
                canShoot = false;
                Invoke("shootTimer", 3);
            }
            
        }
	}
    void shootTimer()
    {
        canShoot = true;
    }
}
