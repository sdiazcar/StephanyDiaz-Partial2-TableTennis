using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public AudioSource Hitball;
    void OnCollisionEnter(Collision collision)
    
    {
     
    }
    // Use this for initialization
    void Start () {
        Hitball = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {
        {
        }
        Debug.Log("Collision detectada");
        {
            Hitball.Play();
        }
        }
       
    }

