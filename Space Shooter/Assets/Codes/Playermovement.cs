using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour {

    Rigidbody rb;
    float horizontal = 0;
    float vertical = 0;
    Vector3 vec;
    public float speed;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float slope;
    float shoottime = 0;
    public float aftershoot;
    public GameObject bullet;
    public Transform bulletrelease;
    AudioSource audio;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();

		
	}

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > shoottime)
        {
            shoottime = Time.time + aftershoot;
            Instantiate(bullet, bulletrelease.position,Quaternion.identity);
            audio.Play();
        }

        
    }

    void FixedUpdate ()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec = new Vector3(horizontal, 0, vertical);

        rb.velocity = vec * speed;

        rb.position = new Vector3
            (Mathf.Clamp(rb.position.x,minX,maxX),
            0.0f,
            Mathf.Clamp(rb.position.z,minZ,maxZ)
            );

        rb.rotation = Quaternion.Euler(0, 0, rb.velocity.x * -slope);



    }
}
