using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Singleton é um design pattern usado quando precisamos chamar métodos e variaveis de uma classe sem precisar de referencia
/// </summary>
public class SimpleSingleton : MonoBehaviour
{
    public float speed;

    public static SimpleSingleton instance { get; private set; }

    private void Awake()
    {
        instance = this;
    }

    public void GetSpeed()
    {
        //faz algo
    }
}
