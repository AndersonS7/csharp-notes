using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //importe essa biblioteca para poder criar events

public class UnityEvents : MonoBehaviour
{
    public UnityEvent onPlayerDeath;

    private float health;

    private void Start()
    {
        TakeDamage(10);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health < 0)
        {
            onPlayerDeath?.Invoke(); //o ? verifica se o delegate é null
        }
    }
}
