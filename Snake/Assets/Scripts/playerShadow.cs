using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShadow : MonoBehaviour {
    public float speed;
    public float rotationSpeed;
    public bool rotate;
    
	void Update () {
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
}
