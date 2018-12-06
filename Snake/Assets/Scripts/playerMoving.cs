﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoving : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public bool rotate;
    public GameObject playerShadow;
    public static bool invis;
    private TrailRenderer trail;
    private SpriteRenderer playerSprite;
    private Collider2D playerCollider;
    public float invisDelay = 10;
    public float counter;

    private void Start()
    {
        trail = GetComponent<TrailRenderer>();
        playerSprite = GetComponent<SpriteRenderer>();
        playerCollider = GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotate = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            rotate = false;
        }
        if (invis && invisDelay > counter)
        {
            counter += Time.deltaTime;
            trail.enabled = false;
            playerSprite.enabled = false;
            playerCollider.enabled = false;
        }
        if (invisDelay <= counter)
        {
            invis = false;
            counter = 0;
            trail.enabled = true;
            playerSprite.enabled = true;
            playerCollider.enabled = true;
        }
    }



    void FixedUpdate()
    {
        transform.position = transform.position - (transform.up * speed * Time.deltaTime);

        if (rotate)
        {
            transform.Rotate(transform.forward * -rotationSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            playerShadow.SetActive(false);
        }
    }
}

