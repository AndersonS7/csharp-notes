using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;

    public void OnHit(IDamegeable damegeable)
    {
        damegeable.ApplyDamage(damage);
    }
}
