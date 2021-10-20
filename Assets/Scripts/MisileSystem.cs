using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisileSystem : ShootingSystem
{
    public override void Shoot()
    {
        var mis = Instantiate(shootingdata.projectile, shotPoint.position, shotPoint.rotation);
        mis.GetComponent<Missile>().SetTarget(GameObject.Find("Meteorito").transform);
    }
}
