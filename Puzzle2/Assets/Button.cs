using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public GameObject Door;
    public GameObject ball;

    public bool Open;

	// Use this for initialization
	void Start () {

        Open = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box")
        {
            Destroy(other.gameObject);
            Destroy(Door.gameObject);
            Destroy(ball.gameObject);

            Open = true;
        }
    }

}
