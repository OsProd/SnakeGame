using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFlip : MonoBehaviour {
    public static bool lefted = false;
    void Update () {
        if (lefted)
        {
            transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
        }
        if (!lefted)
        {
            transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
        }
    }
}
