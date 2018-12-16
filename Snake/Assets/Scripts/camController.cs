using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camController : MonoBehaviour {
    public Transform player;
    public float score;
    public Text myScore;
    public static float maxScore = 0; 
    public Text myCoins;
    public float maxY;
    public float maxGap;
    public static int coins = 0;

	void Update () {
        if (player.transform.position.y  > maxY - maxGap)
        {
            if (player.transform.position.y > maxY)
            {
                maxY = transform.position.y;
            }
            transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        }
        if (Mathf.Round(transform.position.y) > score)
        {
            score = Mathf.Round(transform.position.y);
        }
        if (maxScore < score)
        {
            maxScore = score;
        }
        myScore.text = score.ToString();
        myCoins.text = coins.ToString();
	}
}
