using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float vel;
    public float health;
    public float velrot;
    public float velshoot;
    private float xrot, yrot, zrot;

    public GameObject explosion;
    public GameObject disparo;

    private Rigidbody2D rb;

    Vector3 DisL = new Vector3(0.5f, 0, 0);

    private float direction;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        zrot = 0;
        direction = 0.0f;
        zrot = Input.GetAxisRaw("Horizontal");
        direction = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0)) {
            CrearMisil();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            CrearMisilDoble();
        }
    }

    void CrearMisil()
    {
        Instantiate(disparo, transform.position, Quaternion.identity);
    }

    void CrearMisilDoble()
    {
        Instantiate(disparo, transform.position + DisL, Quaternion.identity);
        Instantiate(disparo, transform.position - DisL, Quaternion.identity);
    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.up * direction * vel * Time.deltaTime);
        rb.transform.Rotate(xrot, yrot, -zrot * velrot * Time.deltaTime , Space.Self);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("mateorito"))
        {
            health = health - 1;
            Instantiate(explosion, transform.position, Quaternion.identity);
        }
    }
}