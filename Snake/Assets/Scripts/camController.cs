using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camController : MonoBehaviour {
    public Transform player;
    public float score;
    public Text myScore;
    public float maxY;
    public float maxGap;

	void Update () {
        if (playerMoving.playerLosed == false && player.transform.position.y  > maxY - maxGap)
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
        myScore.text = score.ToString ();
	}
}
