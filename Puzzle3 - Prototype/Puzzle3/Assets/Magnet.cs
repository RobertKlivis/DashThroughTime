﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour {

    public PointEffector2D pointEffector;

    // Use this for initialization
    void Start()
    {

        pointEffector = GetComponent<PointEffector2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            pointEffector.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            pointEffector.enabled = false;
        }

    }
}