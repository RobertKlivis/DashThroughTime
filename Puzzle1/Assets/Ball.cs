using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector2 vGravity;

    private Vector2 BallSpawn;

    private float gravity = 9.81f;

    public bool Respawn;

    public bool Open;

    // Use this for initialization
    void Start () {

        BallSpawn = transform.position;
        Respawn = false;
        Open = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.transform.tag == "RespawnBall")
        {
            transform.position = BallSpawn;
            Respawn = true;

        }

        if (other.transform.tag == "Open")
        {
            Open = true;
        }

    }
}
