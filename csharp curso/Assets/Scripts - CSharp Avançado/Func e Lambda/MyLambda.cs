using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MyLambda : MonoBehaviour
{
    private int idade = 10;

    //delegate Func
    Func<int, bool> calcIdade = idade => idade > 18;

    //operação lambda
    //private bool maiorDeIdade => idade > 18;


    // Start is called before the first frame update
    void Start()
    {

    }
}
