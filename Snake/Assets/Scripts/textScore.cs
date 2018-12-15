using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScore : MonoBehaviour {
    public Text text; 
	void Start () {
        text.text = camController.maxScore.ToString();
	}
}
