using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCannonCollisionBoat : MonoBehaviour {

	void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "cannonball")
        {
            boatexplosion.isExplode = true;
        }

    }
}
