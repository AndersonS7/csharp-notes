using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Events s�o um tipo especial de Delegates multi-cast. Ambos funcionam da mesma maneira
/// Diferentemente de Delegates, Events s� podem ser acionados ou modificados dentro de sua pr�pria classe
/// Adiciona uma camada a mais de prote��o
/// </summary>
public class Enemy : MonoBehaviour
{
    public delegate void OnEnemyDie();
    public static event OnEnemyDie onEnemyDie;

    private void Start()
    {
        onEnemyDie?.Invoke();
    }
}
