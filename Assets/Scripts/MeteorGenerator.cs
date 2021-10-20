using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{
    public GameObject[] meteor;
    public Transform[] positions;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenerateMeteor());
    }

    IEnumerator GenerateMeteor()
    {
        int num = Random.Range(0, 4);
        int num2 = Random.Range(0, 2);
        Instantiate(meteor[num2], positions[num].position, Quaternion.identity);
        yield return new WaitForSeconds(1.0f);
        StartCoroutine(GenerateMeteor());
    }
}
