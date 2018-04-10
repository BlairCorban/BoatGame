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
                Instantiate(flame, transform.position, flame.transform.rotation);
                isExplosion = true;
                explosion.Play();
                Invoke("StartMuffle", 1);
            }
            
        }

        if(ringing.isPlaying)
        {
            ringing.volume -= 0.2f * Time.deltaTime;
        }
        if(ringing.volume <= 0)
        {
            ringing.Stop();
            ringing.volume = 1;
        }
    }
    void StartMuffle()
    {
        muffled.TransitionTo(0.3f);
        Invoke("endmuffle", 3);
        if (!ringing.isPlaying)
        {
            ringing.volume = 1;
            ringing.Play();
        }
    }
    

    void endmuffle()
    {
        notmuffled.TransitionTo(10);
    }
    
}
