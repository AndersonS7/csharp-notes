using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// Func � um delegate que encapsula um m�todo que tem um par�metro e retorna um valor do tipo especificado pelo par�metro
/// 
/// Lambda � uma fun��o sem nome que calcula e retorna um valor �nico
/// Pode ser usado por delegates ou �rvores de express�o
/// Operador => ("vai para" ou "recebe")
/// Lado esquerdo representa os par�metros de entrada (se houver) e a direita o bloco de instru��es
/// Reduz quantidade de trabalho (linhas) necess�rias para iterar com os dados
/// </summary>
public class Lambdas : MonoBehaviour
{
    //entrada, entrada, sa�da
    Func<float, float, float> spread = (num1, num2) => num1 * num2;

    //entra int e sai bool
    Func<float, bool> isShooting = x => x <= 0f;    

    public GameObject bulletPrefab;

    public float fireCooldown = 2f;

    //public bool isShooting;
    //public bool fire => fireCooldown <= 0f && !isShooting;

    private void Update()
    {
        fireCooldown -= Time.deltaTime;

        if (isShooting(fireCooldown))
        {
            Fire();
            fireCooldown = 2f;
        }
    }

    //void Fire() => Debug.Log("Atirou!");

    void Fire()
    {
        Vector2 spreadPos = new Vector2(spread(0.1f, 2f), transform.position.y);
        Instantiate(bulletPrefab, spreadPos, Quaternion.identity);
    }
}
