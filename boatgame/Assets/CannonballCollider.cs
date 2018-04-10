using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonballCollider : MonoBehaviour {
    public GameObject explosion;
	void OnCollisionEnter(Collision other)
    {
        //Instantiate(explosion, transform.position, explosion.transform.rotation);
        Destroy(gameObject);
    }
}
