using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatelock : MonoBehaviour {
    public Transform tr;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.rotation = Quaternion.identity;
        transform.LookAt(tr.position);
	}
}
