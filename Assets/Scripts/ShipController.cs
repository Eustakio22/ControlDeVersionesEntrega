using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public ShootingSystemData[] shootingData;
    public Transform[] shotPoints;
    private ShootingSystem launcher;

    private void Awake()
    {
        InputSystemKeyboard sk;

        if (TryGetComponent<InputSystemKeyboard>(out sk)) sk.OnShoot += Shoot;
    }

    private void Start()
    {
        launcher = GetComponent<ShootingSystem>();
    }
    void Shoot()
    {
        launcher.Shoot();
    }

    public void SetLauncher(ShootingSystem e)
    {
        launcher = e;
    }

    void Update()
    {
        var input = Input.inputString;
        if (Input.GetKeyDown(KeyCode.B))
        {

            ShootingSystemData sh = Resources.Load<ShootingSystemData>("ShotData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            ShootSystem s = gameObject.AddComponent<ShootSystem>();
            s.shootingdata = shootingData[0];
            s.shotPoint = shotPoints[0];
            launcher = s;         
        }
        if (Input.GetKeyDown(KeyCode.V))
        {

            ShootingSystemData sh = Resources.Load<ShootingSystemData>("MisileData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            MisileSystem m = gameObject.AddComponent<MisileSystem>();
            m.shootingdata = shootingData[1];
            m.shotPoint = shotPoints[0];
            launcher = m;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {

            ShootingSystemData sh = Resources.Load<ShootingSystemData>("DoubleShootData");
            Destroy(gameObject.GetComponent<ShootingSystem>());
            DoubleShootSystem d = gameObject.AddComponent<DoubleShootSystem>();
            d.shootingdata = shootingData[2];
            d.shotPoint = shotPoints[1];
            d.shotPoint = shotPoints[2];
            launcher = d;
        }
    }
}
