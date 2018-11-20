﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour {

    public float Tilt;

    public GameObject Ball;

    // Use this for initialization
    void Start () {

        GameObject Ball = GameObject.Find("Ball");
        Ball ball = Ball.GetComponent<Ball>();

        ball.Respawn = false;

        Tilt = 0;

    }

    // Update is called once per frame
    void Update () {

        GameObject Ball = GameObject.Find("Ball");
        Ball ball = Ball.GetComponent<Ball>();


        if (ball.Respawn == true)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            Tilt = 0;
        }

        if (ball.Respawn == true)
        {
            ball.Respawn = false;
        }

        if (Input.GetKey(KeyCode.Keypad4))
        {
            Tilt += Time.deltaTime * 10;
            transform.rotation = Quaternion.Euler(0, 0, Tilt);
        }

        if (Input.GetKey(KeyCode.Keypad6))
        {
            Tilt += Time.deltaTime * -10;
            transform.rotation = Quaternion.Euler(0, 0, Tilt);

        }

    }
}