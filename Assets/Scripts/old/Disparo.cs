using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    private Rigidbody2D rb2;
    public float veldisparo = 20;


    // Start is called before the first frame update
    void Start()
    {
        var jugadore = GameObject.Find("player").GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();
        rb2.rotation = jugadore.rotation;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        rb2.MovePosition(transform.position + transform.up * veldisparo * Time.deltaTime);
    }
}
