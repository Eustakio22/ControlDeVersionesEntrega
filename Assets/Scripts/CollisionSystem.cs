using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CollisionSystem : MonoBehaviour
{
    [SerializeField]
    private int damage;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<HealthSystem>().LoseHealth(damage);
    }
}
