using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Exemplo multi-cast
/// </summary>
public class Character : MonoBehaviour
{
    private void OnEnable()
    {
        //assina-la com os 2 metodos 
        DelegateExample.myDelegate += DebugName;
        DelegateExample.myDelegate += DestroyMyObj;
    }

    private void Start()
    {
        //chama o delegate
         DelegateExample.myDelegate?.Invoke();
    }

    private void OnDisable()
    {
        //retira assinatura dos metodos
        if (DelegateExample.myDelegate == null)
            return;

        DelegateExample.myDelegate -= DebugName;
        DelegateExample.myDelegate -= DestroyMyObj;
    }

    public void DebugName()
    {
        Debug.Log("Wenessss");
    }

    public void DestroyMyObj()
    {
        Destroy(gameObject);
    }
}
