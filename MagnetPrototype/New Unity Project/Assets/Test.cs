using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    private  float movingSpeed = 10.0f;

    bool moving = false;

	// Use this for initialization
	void Start () {

        moving = false;
		
	}
	
	// Update is called once per frame
	void Update () {

        if (moving == true)
        {
            transform.position = Vector2.Lerp(transform.position, transform.TransformPoint(Vector2.right), movingSpeed * Time.deltaTime);
        }
		
	}

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.transform.tag == "Car")
        {
            moving = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.transform.tag == "Car")
        {
            moving = false;
        }
    }
    
}
