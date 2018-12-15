using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleSpawner : MonoBehaviour {
    public GameObject Missle;
    public Transform myCamera;
    int spawnCoord = 100;

	void Update () {
		if (myCamera.position.y >= spawnCoord)
        {
            Debug.Log("sp");
            Instantiate(Missle, transform.position, Quaternion.identity);
            spawnCoord += 100; 
        }
    }
}
