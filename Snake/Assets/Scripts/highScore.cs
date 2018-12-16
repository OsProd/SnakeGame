using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highScore : MonoBehaviour {
    private LineRenderer highLine;

    private void Start()
    {
        highLine = GetComponent<LineRenderer>();
    }
    void Update () {
        if (UIButtons.renderLine)
        {
            transform.position = new Vector2(transform.position.x, camController.maxScore);
            highLine.SetPosition(0, new Vector3(highLine.GetPosition(0).x, camController.maxScore, highLine.GetPosition(0).z));
            highLine.SetPosition(1, new Vector3(highLine.GetPosition(1).x, camController.maxScore, highLine.GetPosition(1).z));
            UIButtons.renderLine = false;
        }
    }
}
