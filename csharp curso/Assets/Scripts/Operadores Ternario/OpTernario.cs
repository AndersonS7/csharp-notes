using UnityEngine;

public class OpTernario : MonoBehaviour
{
    public int moedasDoHeroi;
    public int valorDaVida;
    string result;

    void Start()
    {
        // condi��o ? Verdadeiro : Falso
        result = moedasDoHeroi >= valorDaVida ? "Pode comprar": "N�o pode comprar";

        print(result);
    }
}
