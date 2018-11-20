using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour {

    private Rigidbody2D bridge;

    public GameObject Ball;

    // Use this for initialization
    void Start () {

        bridge = GetComponent<Rigidbody2D>();
        bridge.bodyType = RigidbodyType2D.Kinematic;

    }
	
	// Update is called once per frame
	void Update () {

        GameObject Ball = GameObject.Find("Ball");
        Ball ball = Ball.GetComponent<Ball>();

        if (ball.Open == true)
        {
            bridge = GetComponent<Rigidbody2D>();
            bridge.bodyType = RigidbodyType2D.Dynamic;
        }

    }
}
