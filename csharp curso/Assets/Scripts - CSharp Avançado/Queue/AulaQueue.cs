using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Queue é uma coleção de objetos, semelhante a um Array ou List
/// A diferença é que você só consegue "manipular" o primeiro e último elemento
/// Enqueue => Add objeto ao final
/// Dequeue => Remove e retorna o objeto no inicio
/// Peek => Retorna o objeto ao inicio sem remover-lo
/// </summary>
public class AulaQueue : MonoBehaviour
{
    //Queue myQueue = new Queue<int>();
    Queue<int> myQueue = new Queue<int>();

    public int[] myQueueArray;

    // Start is called before the first frame update
    void Start()
    {
        myQueue.Enqueue(5);
        myQueue.Enqueue(7);
        myQueue.Enqueue(23);

        int v = myQueue.Dequeue();
        Debug.Log(v); //vai ter que aparecer o 5

        v = myQueue.Dequeue();
        Debug.Log(v); //vai ter que aparecer o 7

        myQueue.Enqueue(100);

        v = myQueue.Dequeue();
        v = myQueue.Dequeue();
    }
}
