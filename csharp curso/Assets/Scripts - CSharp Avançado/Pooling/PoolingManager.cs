using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    public static PoolingManager instance;

    private void Awake()
    {
        instance = this;
    }

    //pooling

    public void ObjectPooling(List<GameObject> pooledBullets, GameObject bulletPrefab, int magazineSize)
    {
        pooledBullets.Clear();

        for (int i = 0; i < magazineSize; i++)
        {
            GameObject p = Instantiate(bulletPrefab);
            p.SetActive(false);

            pooledBullets.Add(p);
        }
    }

    public GameObject GetPooledObjects(List<GameObject> pooledBullets)
    {
        for (int i = 0; i < pooledBullets.Count; i++)
        {
            if (!pooledBullets[i].activeInHierarchy)
                return pooledBullets[i];
        }

        return null;
    }

}
