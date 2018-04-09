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
        
		if(Input.GetAxis("R2") > 0)
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
        
       

        transform.Rotate(Vector3.down * -rotationspeed * Input.GetAxis("LeftX") * Time.deltaTime);
        
        
        transform.Translate(0,0,speed * Time.deltaTime);
	}
}
