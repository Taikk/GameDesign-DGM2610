using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public FloatData scoreObj;
    public Text scoreText;
    public string scoreObjString;

    private void Update()
    {
        scoreObjString = scoreObj.ToString();
        scoreText.text = scoreObjString;
    }
}
