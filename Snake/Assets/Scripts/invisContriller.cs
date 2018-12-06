using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisContriller : MonoBehaviour {
    public GameObject shadow;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            Destroy(gameObject);
            Destroy(shadow);
            playerMoving.invis = true;
        }
        if (collision.gameObject.tag == "worldEnd")
        {
            Destroy(gameObject);
            Destroy(shadow);
        }
    }

}
