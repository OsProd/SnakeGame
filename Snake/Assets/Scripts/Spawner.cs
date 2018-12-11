using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float radiusO;
    public float radiusB;
    public LayerMask whatIs;
    public LayerMask whatIs4Bon;
    bool noSpawnObs;
    bool noSpawnBon;
    int mnoj;
    int rand4mnoj;
    float rand;
    public GameObject[] obs;
    int randomObs;
    public GameObject[] bon;
    int randonBon;
    

    void Update()
    {
        
        rand = Random.Range(1f, 4.4f);
        rand4mnoj = Random.Range(0, 2);
        if (rand4mnoj == 0)
        {
            mnoj = 1;
        } 
        if (rand4mnoj == 1)
        {
            mnoj = -1;
        }
        rand = rand * mnoj;
        noSpawnBon = Physics2D.OverlapCircle(transform.position, radiusB, whatIs4Bon);
        noSpawnObs = Physics2D.OverlapCircle(transform.position, radiusO, whatIs);

        randomObs = Random.Range(0, obs.Length);
        randonBon = Random.Range(0, bon.Length);

        if (enemyFlip.lefted && randomObs == 4)
        {
            randomObs = randomObs - Random.Range(0, obs.Length - 1);
        }

        if (!noSpawnObs)
        {
            Instantiate(obs[randomObs], new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            radiusO = Random.Range(15f, 25f);
        }
        if (!noSpawnBon)
        {
            Instantiate(bon[randonBon], new Vector3(rand, transform.position.y, 0), Quaternion.identity);
            radiusB = Random.Range(5f, 10f);
        }
    }
}
