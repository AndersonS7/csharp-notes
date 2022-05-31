using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour, IDamegeable
{
    public int currentHealth { get; set; }

    public void ApplyDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //Destroy o monstro...
    }

    //como seria usado para tirar a vida do monstro.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Bullet>())
        {
            //ApplyDamage(10);
            collision.GetComponent<Bullet>().OnHit(this); // passando o próprio IDamegeable dessa classe
        }
    }
}
