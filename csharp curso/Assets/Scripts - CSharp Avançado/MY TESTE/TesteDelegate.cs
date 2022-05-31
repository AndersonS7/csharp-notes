using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteDelegate : MonoBehaviour
{

    private void OnEnable()
    {
        DelegatePlayer.delegatePlayer += DebugName;
        DelegatePlayer.delegatePlayer += DebugName2;
    }

    // Start is called before the first frame update
    void Start()
    {
        DelegatePlayer.delegatePlayer.Invoke();
    }

    public void DebugName()
    {
        Debug.Log("Olá...");
    }

    public void DebugName2()
    {
        Debug.Log("Olá 2...");
    }
}
