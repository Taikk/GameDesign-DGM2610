using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public FloatData scoreObj;
    public Text scoreText;

    private void Update()
    {
        scoreText.text = scoreObj.value.ToString();
    }
}
