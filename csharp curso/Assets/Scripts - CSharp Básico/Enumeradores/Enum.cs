using UnityEngine;

public class Enum : MonoBehaviour
{
    enum AI { Atacar, Correr, Patrulhar}

    void Start()
    {
        AI vilao1 = AI.Atacar;
        AI vilao2 = AI.Correr;

        print(vilao1);
    }

    void Update()
    {
        
    }
}
