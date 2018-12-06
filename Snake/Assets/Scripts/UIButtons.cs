using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour {
    public static bool renderLine;
    public void Restart()
    {
        renderLine = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
