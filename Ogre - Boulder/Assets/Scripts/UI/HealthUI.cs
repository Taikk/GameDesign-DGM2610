using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public FloatData healthObj;

    public Image healthBar;

    private void Update()
    {
        healthBar.fillAmount = healthObj.Value;
    }
}
