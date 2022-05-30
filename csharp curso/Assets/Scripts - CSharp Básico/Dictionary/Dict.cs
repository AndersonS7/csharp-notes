using System.Collections.Generic;
using UnityEngine;

public class Dict : MonoBehaviour
{

    void Start()
    {
        Dictionary<string,string> vilao = new Dictionary<string, string>();

        vilao.Add("matador", "é o principal");
        vilao.Add("atirador", "é o segundo");

        foreach (string chave in vilao.Keys)
        {
            if (chave == "atirador")
            {
                print(chave);
            }
        }
    }
}

/*
 Dictionary<chave, valor>
 */
