using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private float turnSpeed;

    private InputSystemKeyboard inputSystem;

    void Awake()
    {
        inputSystem = GetComponent<InputSystemKeyboard>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += inputSystem.ver * speed * Time.deltaTime * transform.up;
        transform.Rotate(inputSystem.hor * Time.deltaTime * turnSpeed * new Vector3(0, 0, -1));
    }
}
