using UnityEngine;

public class Laco : MonoBehaviour
{
    int x;

    void Start()
    {
        //while (x <= 10)
        //{
        //    print("while: " + x);
        //    x++;
        //}

        do
        {
            print("do while: " + x);
            x++;
        } while (x <= 10);
    }
}

/*
 * LAÇO WHILE => TESTE NO COMEÇO DO LAÇO
 * LAÇO DO WHILE => TESTE NO FIM DO LAÇO
 */
