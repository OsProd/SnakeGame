using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIButtons : MonoBehaviour {
    public static bool renderLine;

    private void Start()
    {
        if (camController.maxScore > 0)
        {
            renderLine = true;
        }
    }
    public void Restart()
    {

        SceneManager.LoadScene("SampleScene");
    }
}
