using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem particle;

    private InputSystemKeyboard inputSystem;

    void Awake()
    {
        inputSystem = GetComponent<InputSystemKeyboard>();
    }

    void Update()
    {
        var engine = gameObject.transform.GetChild(1);
        if(inputSystem.ver > 0)
        {
            engine.gameObject.SetActive(true);
        }
        else
        {
            engine.gameObject.SetActive(false);
        }
    }
}
