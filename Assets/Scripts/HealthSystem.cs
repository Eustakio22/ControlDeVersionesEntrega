using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    private int MaxHealth;

    [SerializeField]
    private int CurrentHealth;

    public event Action<int> UpdateScore = delegate { };

    public event Action OnDeath = delegate { };


    void Awake()
    {
        CurrentHealth = MaxHealth;
        UpdateScore(CurrentHealth);
    }

    public void LoseHealth(int dmg)
    {
        CurrentHealth = CurrentHealth - dmg;
        UpdateScore(CurrentHealth);

        if (CurrentHealth <= 0)
        {
            OnDeath();
        }
    }
}
