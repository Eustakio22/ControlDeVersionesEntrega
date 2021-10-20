using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSystem : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem explosion;

    void OnEnable()
    {
        GetComponent<HealthSystem>().OnDeath += Death;
    }

    void OnDisable()
    {
        GetComponent<HealthSystem>().OnDeath -= Death;
    }

    public void Death()
    {
        gameObject.SetActive(false);
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
