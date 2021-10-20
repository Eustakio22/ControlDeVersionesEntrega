using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    void OnEnable()
    {
        ScoreSystem.UpdateText += UpText;
    }

    void OnDisable()
    {
        ScoreSystem.UpdateText += UpText;
    }

    void UpText(int health)
    {
        GetComponent<Text>().text = "Health:" + health;
    }
}
