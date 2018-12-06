using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worldEnd : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "worldEnd")
        {
            Destroy(gameObject);
        }
    }
}
