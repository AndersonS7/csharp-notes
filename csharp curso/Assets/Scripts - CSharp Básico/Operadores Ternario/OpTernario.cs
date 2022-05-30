using UnityEngine;

public class OpTernario : MonoBehaviour
{
    public int moedasDoHeroi;
    public int valorDaVida;
    string result;

    void Start()
    {
        // condição ? Verdadeiro : Falso
        result = moedasDoHeroi >= valorDaVida ? "Pode comprar": "Não pode comprar";

        print(result);
    }
}
