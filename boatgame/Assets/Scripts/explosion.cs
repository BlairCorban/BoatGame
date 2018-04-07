using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion : MonoBehaviour {
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P))
        {
            rb.AddExplosionForce(9000,this.transform.position, 1, 1);
        }
	}
}
