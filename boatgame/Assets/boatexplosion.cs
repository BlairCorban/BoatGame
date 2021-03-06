﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boatexplosion : MonoBehaviour {
    public Rigidbody sack1;
    public Rigidbody sack2;
    public Rigidbody sack3;
    public GameObject flameprefab;
    private bool isExplode;
	// Use this for initialization
	void Start () {
        isExplode = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(isExplode)
        {
            sack1.AddExplosionForce(900, sack1.transform.position, 1);
            sack2.AddExplosionForce(900, sack1.transform.position, 1);
            sack3.AddExplosionForce(900, sack1.transform.position, 1);
            GameObject flame = Instantiate(flameprefab,transform.position, flameprefab.transform.rotation);
            flame.transform.parent = gameObject.transform;
            flame.transform.localScale = new Vector3(3f, 3f, 3f);
            Invoke("Destroyitems", 5);
            isExplode = false;
        }
	}
    void Destroyitems()
    {
        Destroy(sack1.gameObject);
        Destroy(sack2.gameObject);
        Destroy(sack3.gameObject);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "cannonball")
        {
            isExplode = true;


        }
    }
}
