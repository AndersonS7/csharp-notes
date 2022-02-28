using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break : MonoBehaviour
{
    int x;

    // Start is called before the first frame update
    void Start()
    {
        for (int c = 0; c <= 10; c++)
        {
            print("contando: " + c);

            if (c == 5)
            {
                break;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*
 * BREAK - SERVE PARA CANCELAR UMA AÇÃO
 * CONTINUE - SERVE PARA ABANDONAR A INTERAÇÃO
 */
