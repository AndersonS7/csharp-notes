using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Delegate armazena um m�todo para ser usado como vari�vel
/// Exemplo single-cast
/// </summary>
public class DelegateExample : MonoBehaviour
{
    public delegate void MyDelegate();
    public static MyDelegate myDelegate;



    //private void Start()
    //{
    //    myDelegate = DebugName;        
    //}

    //public void DebugName(string name)
    //{
    //    Debug.Log(name);
    //}
}
