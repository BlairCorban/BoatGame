using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campivot : MonoBehaviour {
    public Transform boat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = boat.position;
        transform.Rotate(Vector3.up * 50 * Input.GetAxis("RightX") * Time.deltaTime);
	}
}
