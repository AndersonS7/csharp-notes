using UnityEngine;

public class Metodos : MonoBehaviour
{
    metodos s = new metodos();

    void Start()
    {
        print(s.soma(2,5)); // metodo simples
        print(metodos.mult(2,5)); // metodo est�tico
    }

    class metodos
    {
        // m�todo s�mples com retorno
        public int soma(int a, int b)
        {
            return a + b;
        }

        // m�todo est�tico
        public static int mult(int a, int b)
        {
            return a * b;
        }
    }
}
