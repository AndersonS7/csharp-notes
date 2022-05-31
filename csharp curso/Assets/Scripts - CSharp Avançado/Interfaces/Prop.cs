using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour, IDamegeable
{
    public int currentHealth { get; set; }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            DestroyProp();
        }
    }

    private void DestroyProp()
    {
        //codigo para destruir...
    }
}
