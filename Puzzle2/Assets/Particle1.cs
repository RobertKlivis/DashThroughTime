using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle1 : MonoBehaviour {

    private ParticleSystem ps;


	// Use this for initialization
	void Start () {

        ps = GetComponent<ParticleSystem>();

        ps.Stop();
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ps.Play();
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            ps.Stop();
        }
		
	}
}
