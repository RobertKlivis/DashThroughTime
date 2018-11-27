using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {
    public AudioSource asource;
    public AudioClip magnetSound;
	// Use this for initialization
	void Start () {
        asource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            asource.enabled = true;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            asource.enabled = false;
        }
	}

   public void PlayMagnetSound()
    {
        GetComponent<AudioSource>().PlayOneShot(magnetSound);
    }
}
