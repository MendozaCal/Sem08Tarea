using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    [SerializeField]
    private GameObject bulletPrefab2;
    
    private float shootTimer;
    [SerializeField]
    private float shootDelayTime;

    void Update()
    {
        Timer();
        Shoot();
    }

    void Timer()
    {
        shootTimer += Time.deltaTime;
    }

    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && shootTimer >= shootDelayTime)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            shootTimer = 0;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && shootTimer >= shootDelayTime)
        {
            GameObject obj = Instantiate(bulletPrefab2);
            obj.transform.position = transform.position;
            shootTimer = 0;
        }
    }
}
