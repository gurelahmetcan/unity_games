﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidmovement : MonoBehaviour {

	Rigidbody rb;
    public float speed;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;

	}

}
