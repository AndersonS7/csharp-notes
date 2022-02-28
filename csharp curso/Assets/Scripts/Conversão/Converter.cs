using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Converter : MonoBehaviour
{
    int carteira = 100;
    float carteira2 = 10.5f;
    bool venda = true;
    string texto;

    void Start()
    {
        //carteira = (int)carteira2;
        carteira = Convert.ToInt32(venda);
        texto = carteira.ToString();

        print(carteira);
    }
}

/*
    CONVERSÃO SIMPLES (CAST)
    carteira = (int)carteira2;
    --------------------------
    
    CONVERT.
    carteira = Convert.ToInt32(venda);
    --------------------------

    TOSTRING()
    texto = carteira.ToString();
 */
