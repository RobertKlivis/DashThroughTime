using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle : MonoBehaviour {

    private ParticleSystem ps;

	// Use this for initialization
	void Start () {

        ps = GetComponent<ParticleSystem>();

        ps.Stop();
        
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            ps.Play();
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            ps.Stop();
        }

    }
}
