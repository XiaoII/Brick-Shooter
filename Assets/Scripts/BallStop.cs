using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStop : MonoBehaviour {

    public Rigidbody2D ball;
    public BallController ballControl;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ball.velocity = Vector2.zero;
            ballControl.currentBallState = BallController.ballState.aim;
        }
    }
}
