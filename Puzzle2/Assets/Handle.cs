using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour {

    public GameObject Ball;

    // Use this for initialization
    void Start()
    {

        GameObject Ball = GameObject.Find("Ball");
        Ball ball = Ball.GetComponent<Ball>();

        ball.Respawn = false;

    }

    // Update is called once per frame
    void Update()
    {

        GameObject Ball = GameObject.Find("Ball");
        Ball ball = Ball.GetComponent<Ball>();


        if (ball.Respawn == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (ball.Respawn == true)
        {
            ball.Respawn = false;
        }

    }
}
