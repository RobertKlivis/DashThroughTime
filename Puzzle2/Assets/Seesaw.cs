using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seesaw : MonoBehaviour {

    public float Tilt;

    public GameObject Button;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        GameObject Button = GameObject.Find("Button");
        Button button = Button.GetComponent<Button>();

        if (button.Open == true)
        {
            Tilt += Time.deltaTime * -10;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, Tilt);
        }


    }
}
