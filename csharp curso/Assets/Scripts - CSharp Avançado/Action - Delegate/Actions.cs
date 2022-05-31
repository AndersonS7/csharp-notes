using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Action � um delegate pronto
/// Usado para criar um delegate com retorno void
/// Seus par�metros s�o passados atraves do simbolo de <> | Action<string>
/// � poss�vel passar mais de um par�metro Action<string, int>
/// * O m�todo tem que obrigat�riamente ter o retorno void
/// </summary>
public class Actions : MonoBehaviour
{
    // isso aqui...
    public static Action OnGameOver;

    //� a mesma coisa disso aqui...
    //public delegate void OnGameOver();
    //public static event OnGameOver onGameOver;

    float health;
    public void Damage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            //OnGameOver?.Invoke();
        }
    }
}
