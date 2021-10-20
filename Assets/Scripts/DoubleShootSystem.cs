using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleShootSystem : ShootingSystem
{
    public override void Shoot()
    {
        var dShot1 = Instantiate(shootingdata.projectile, shotPoint.position, shotPoint.rotation);
        var dShot2 = Instantiate(shootingdata.projectile, shotPoint.position, shotPoint.rotation);
        dShot1.GetComponent<Rigidbody2D>().AddForce(shotPoint.transform.up * shootingdata.fireForce);
        dShot2.GetComponent<Rigidbody2D>().AddForce(shotPoint.transform.up * shootingdata.fireForce);
    }
}

