using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShotData");
        Destroy(other.gameObject.GetComponent<ShootingSystem>());
        ShootSystem s = other.gameObject.AddComponent<ShootSystem>();
        s.shootingdata = sh;
        s.shotPoint = gameObject.GetComponent<ShipController>().shotPoints[0];
        other.gameObject.GetComponent<ShipController>().SetLauncher(s);
        Destroy(this.gameObject);
    }
}
