using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScore : MonoBehaviour {
    public GameObject highScoreLine;
    public GameObject text;
    public Transform canvas;


    void Update () {
        if (UIButtons.renderLine)
        {
            Instantiate(highScoreLine, new Vector3(0, camController.maxScore, 0), Quaternion.identity);
            Instantiate(text, new Vector3 (0, camController.maxScore, 0), Quaternion.identity, canvas);
            UIButtons.renderLine = false;
        }
    }
}
