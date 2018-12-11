using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisContriller : MonoBehaviour {
    public float radius;
    public LayerMask whatis;
    public bool delete;

    private void Update()
    {
        delete = Physics2D.OverlapCircle(transform.position, radius, whatis);
        if (delete)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            Destroy(gameObject);
            playerMoving.invis = true;
        }
        if (collision.gameObject.tag == "worldEnd")
        {
            Destroy(gameObject);
        }
    }
}
