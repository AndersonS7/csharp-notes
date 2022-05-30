using UnityEngine;

public class Vetores : MonoBehaviour
{

    void Start()
    {
        // ARRAY ---------
        //int[] array = { 1, 2, 3 };
        //int[] array = new int[3] {3,2,1}; // passando a quantidade de elementos quando o array é declarado
        /*int[] array = new int[3];
        array[0] = 1;
        array[1] = 2;
        array[1] = 3;*/

        // MATRIZ ---------
        /*int[,] matriz = new int[2,2];
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 4;*/

        int[,] matriz = new int[2, 2];
        int valor = 1;

        for (int linha = 0; linha <= 1; linha++)
        {
            for (int coluna = 0; coluna <= 1; coluna++)
            {
                matriz[linha, coluna] = valor;
                valor++;
            }
        }

        for (int linha = 0; linha <= 1; linha++)
        {
            for (int coluna = 0; coluna <= 1; coluna++)
            {
                print($"{linha} : {coluna} = {matriz[linha, coluna]}");
            }
        }
    }
}
