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
 * LA�O WHILE => TESTE NO COME�O DO LA�O
 * LA�O DO WHILE => TESTE NO FIM DO LA�O
 */
