using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    private Rigidbody2D box;
    public SpriteRenderer boxSprite;

    public GameObject Ball;

    // Use this for initialization
    void Start()
    {

        box = GetComponent<Rigidbody2D>();
        box.bodyType = RigidbodyType2D.Kinematic;

        boxSprite = GetComponent<SpriteRenderer>();
        boxSprite.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

        GameObject Ball = GameObject.Find("Ball");
        Ball ball = Ball.GetComponent<Ball>();

        if (ball.Open == true)
        {
            box = GetComponent<Rigidbody2D>();
            box.bodyType = RigidbodyType2D.Dynamic;

            boxSprite.enabled = true;
        }

    }
}
