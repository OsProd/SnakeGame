using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoving : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public bool rotate;
    public GameObject playerShadow;
    public static bool playerLosed = false;

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
            playerLosed = true;
            Destroy(gameObject);
            Destroy(playerShadow);
        }
    }
}

