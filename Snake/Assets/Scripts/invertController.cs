using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invertController : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        bool a;
        if (collision.gameObject.tag == "Player")
        {
            a = true;
            Destroy(gameObject);
            playerMoving.rotationSpeed = playerMoving.rotationSpeed * -1;
            playerShadow.rotationSpeed = playerShadow.rotationSpeed * -1;
            rotorRotate.speed = rotorRotate.speed * -1;
            if (enemyFlip.lefted == true && a)
            {
                enemyFlip.lefted = false;
                a = false;
            }
            if (enemyFlip.lefted == false && a)
            {
                enemyFlip.lefted = true;
                a = false;
            }
        }
        if (collision.gameObject.tag == "worldEnd")
        {
            Destroy(gameObject);
        }
    }
}
