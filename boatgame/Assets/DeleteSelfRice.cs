using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteSelfRice : MonoBehaviour {	
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "water")
        {
            Destroy(gameObject);
        }
    }
}
