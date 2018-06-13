﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickColourController : MonoBehaviour {

    public Gradient gradient;
    private SpriteRenderer renderer;

	// Use this for initialization
	void Start () {
        renderer = GetComponent<SpriteRenderer>();
        renderer.color = gradient.Evaluate(Random.Range(0f, 1f));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
