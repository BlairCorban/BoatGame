using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cannonballcontroller : MonoBehaviour {
    public float speed;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "player1")
        {
            Debug.Log("player 1 was hit");
            SceneManager.LoadScene("AWin");
        }
        if(other.gameObject.tag == "player2")
        {
            Debug.Log("player 2 was hit");
            SceneManager.LoadScene("BWin");
        }
    }
    void player1wins()
    {
        Debug.Log("AWin");
        SceneManager.LoadScene("AWin");
    }
    void player2wins()
    {
        Debug.Log("BWin");
        SceneManager.LoadScene("BWin");
    }
}
