﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            this.gameObject.SetActive(false);
        }
    }

}
