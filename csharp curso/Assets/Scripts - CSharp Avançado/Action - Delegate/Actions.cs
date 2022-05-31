using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Action é um delegate pronto
/// Usado para criar um delegate com retorno void
/// Seus parâmetros são passados atraves do simbolo de <> | Action<string>
/// É possível passar mais de um parâmetro Action<string, int>
/// * O método tem que obrigatóriamente ter o retorno void
/// </summary>
public class Actions : MonoBehaviour
{
    // isso aqui...
    public static Action OnGameOver;

    //é a mesma coisa disso aqui...
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
