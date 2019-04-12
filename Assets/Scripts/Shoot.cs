﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;
    public float speed = 5;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello world!");

        //GameObject.Instantiate(bullet, transform.position,transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Hello Again!");

        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody rgd = b.GetComponent<Rigidbody>();
            rgd.velocity = transform.forward * speed;
        }
    }
}
