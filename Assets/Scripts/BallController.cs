﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public enum ballState
    {
        aim,
        fire,
        wait,
        endShot
    }

    public ballState currentBallState;

    public Rigidbody2D ball;
    private Vector2 mouseStartPosition;
    private Vector2 mouseEndPosition;
    private float ballVelocityX;
    private float ballVelocityY;
    public float constantSpeed;
    public GameObject arrow;


	// Use this for initialization
	void Start () {
        currentBallState = ballState.aim;

    }
	
	// Update is called once per frame
	void Update () {
        switch(currentBallState)
        {
            case ballState.aim:
                if (Input.GetMouseButtonDown(0))
                {
                    MouseClicked();
                }
                if (Input.GetMouseButton(0))
                {
                    MouseDragged();
                }
                if (Input.GetMouseButtonUp(0))
                {
                    ReleaseMouse();
                }
                break;
            case ballState.fire:
                break;
            case ballState.wait:
                break;
            case ballState.endShot:
                break;
            default:
                break;
        }


        
		
	}

    public void MouseClicked()
    {
        mouseStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mouseStartPosition);
       
    }

    public void MouseDragged()
    {
     
        //move the arrow
        arrow.SetActive(true);
        Vector2 tempMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float diffX = mouseStartPosition.x - tempMousePosition.x;
        float diffY = mouseStartPosition.y - tempMousePosition.y;
        if (diffY <= 0)
        {
            diffY = 0.01f;
        }
        float theta = Mathf.Rad2Deg * Mathf.Atan(diffX / diffY);
        arrow.transform.rotation = Quaternion.Euler(0f, 0f, -theta);
    }

    public void ReleaseMouse()
    {
        arrow.SetActive(false);
        mouseEndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ballVelocityX = (mouseStartPosition.x - mouseEndPosition.x);
        ballVelocityY = (mouseStartPosition.y - mouseEndPosition.y);
        Vector2 tempVelocity = new Vector2(ballVelocityX, ballVelocityY).normalized;
        ball.velocity = constantSpeed * tempVelocity;
        if(ball.velocity == Vector2.zero)
        {
            return;
        }
        currentBallState = ballState.fire;

    }
}
