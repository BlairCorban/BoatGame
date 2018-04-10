using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audiomuffler : MonoBehaviour {
	public AudioMixerSnapshot muffled;
	public AudioMixerSnapshot notmuffled;
    public AudioSource ringing;
    public AudioSource explosion;
    public GameObject flame;
    public bool isExplosion;
	// Use this for initialization
	void Start () {
        isExplosion = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if(!isExplosion)
            {
                GameObject flameobj = Instantiate(flame, transform.position, flame.transform.rotation);
                flameobj.transform.parent = gameObject.transform;
                isExplosion = true;
                explosion.Play();
                Invoke("StartMuffle", 1);
            }
            
        }

        if(ringing.isPlaying)
        {
            ringing.volume -= 0.1f * Time.deltaTime;
        }
        if(ringing.volume <= 0)
        {
            ringing.Stop();
            ringing.volume = 0.75f;
        }
    }
    void StartMuffle()
    {
        muffled.TransitionTo(0.3f);
        Invoke("endmuffle", 3);
        if (!ringing.isPlaying)
        {
            ringing.volume = 0.75f;
            ringing.Play();
        }
    }
    

    void endmuffle()
    {
        notmuffled.TransitionTo(15);
    }
    
}
