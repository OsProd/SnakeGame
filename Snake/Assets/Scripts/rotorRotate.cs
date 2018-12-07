using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotorRotate : MonoBehaviour {
    public float speed;

	void Update () {
        transform.Rotate(transform.forward * -speed * Time.deltaTime);
    }
}
