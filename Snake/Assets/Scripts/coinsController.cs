using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsController : MonoBehaviour {
    public GameObject shadow;
    //public GameObject coinParticles;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(shadow);
            //Instantiate(coinParticles, transform.position, Quaternion.identity);
        }
        if (collision.gameObject.tag == "worldEnd")
        {
            Destroy(gameObject);
            Destroy(shadow);
        }
    }
}
