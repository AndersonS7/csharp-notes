using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private int magazine;
    [SerializeField] private Transform firePoint;

    private List<GameObject> pooledBullets = new List<GameObject>();

    private PoolingManager pooling;

    private void Start()
    {
        pooling = PoolingManager.instance;
        pooling.ObjectPooling(pooledBullets, bullet, magazine);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = pooling.GetPooledObjects(pooledBullets);

            if (bullet == null)
                return;

            bullet.transform.position = firePoint.position;
            bullet.transform.rotation = firePoint.rotation;
            bullet.SetActive(true);
        }
    }
}
