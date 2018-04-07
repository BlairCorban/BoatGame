using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {
    public float speed;
    public float maxspeed;
    public float accel;
    public float rotationspeed;
	// Use this for initialization
	void Start () {
        speed = 0;
        maxspeed = 10;
	}
	
	// Update is called once per frame
	void Update () {
        if(speed > maxspeed)
        {
            speed = maxspeed;    
        }
                
        if(speed < 0)
        {
            speed = 0;
        }
        
		if(Input.GetKey(KeyCode.UpArrow))
        {
            speed += accel;
        }        
        else
        {
            if(speed > 0)
            {
                speed -= accel;
            }
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * rotationspeed * Time.deltaTime);
        }
        transform.Translate(0,0,speed * Time.deltaTime);
	}
}
