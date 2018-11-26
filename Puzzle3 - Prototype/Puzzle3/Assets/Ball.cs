using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Vector2 vGravity;

    private Vector2 BallSpawn;

    private float gravity = 9.81f;

    public bool Respawn;

    public bool Open;

    public GameObject car;
    private Rigidbody2D ball;

    // Use this for initialization
    void Start()
    {

        BallSpawn = transform.position;
        Respawn = false;
        Open = false;

        ball = GetComponent<Rigidbody2D>();
        ball.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {

        GameObject car = GameObject.Find("Car");
        Car carScript = car.GetComponent<Car>();

        if (carScript.useMagnet == true)
        {
            ball = GetComponent<Rigidbody2D>();
            ball.bodyType = RigidbodyType2D.Dynamic;
        }

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
