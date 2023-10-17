using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

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
        if (Input.GetKeyDown(KeyCode.Space) && shootTimer >= shootDelayTime)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            shootTimer = 0;
        }
    }
}
