using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{
 
    public float hor { get; private set; }
    public float ver { get; private set; }

    public event Action OnShoot = delegate { };

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1")) OnShoot();

    }
}
