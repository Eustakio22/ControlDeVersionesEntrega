using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ScoreSystem : MonoBehaviour
{
    public static event Action <int> UpdateText = delegate { };

    void OnEnable()
    {
        GetComponent<HealthSystem>().UpdateScore += UpScore;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().UpdateScore -= UpScore;
    }

    void UpScore(int CHealth)
    {
        UpdateText(CHealth);
    }
}
