using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotorRotate : MonoBehaviour {
    public static float speed = 100;

	void Update () {
        transform.Rotate(transform.forward * -speed * Time.deltaTime);
    }
}
