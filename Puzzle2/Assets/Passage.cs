using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passage : MonoBehaviour {
    public GameObject redWall;
    public GameObject blueWall;
	// Use this for initialization
	void Start () {
        redWall.SetActive(false);
        blueWall.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            redWall.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            redWall.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            blueWall.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            blueWall.SetActive(false);
        }
	}
}
