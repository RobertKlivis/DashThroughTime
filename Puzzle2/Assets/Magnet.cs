using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour {

    public PointEffector2D pointEffector;
    public Audio audio;
    bool magnetAffectBridge = false;

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
            audio.PlayMagnetSound();
        }

            if (Input.GetKeyUp(KeyCode.Space))
        {
            pointEffector.enabled = false;
        }

    }
}
