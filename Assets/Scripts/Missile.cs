using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public void SetTarget(Transform target)
    {
        var direction = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x);
        transform.Rotate(new Vector3(0, 0, direction));
    }
}
