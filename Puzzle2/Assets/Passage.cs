using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour {
    public GameObject redWall;
    public GameObject blueWall;
	// Use this for initialization
	void Start () {
        redWall.SetActive(false);
        blueWall.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "red button")
        {
            Debug.Log("Button activated");
            redWall.SetActive(true);
            blueWall.SetActive(false);
        }
    }
}
