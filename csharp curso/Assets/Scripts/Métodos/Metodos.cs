using UnityEngine;

public class Metodos : MonoBehaviour
{
    metodos s = new metodos();

    void Start()
    {
        print(s.soma(2,5)); // metodo simples
        print(metodos.mult(2,5)); // metodo estático
    }

    class metodos
    {
        // método símples com retorno
        public int soma(int a, int b)
        {
            return a + b;
        }

        // método estático
        public static int mult(int a, int b)
        {
            return a * b;
        }
    }
}
