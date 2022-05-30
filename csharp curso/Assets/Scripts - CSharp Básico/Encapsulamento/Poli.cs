using UnityEngine;

public class Poli : MonoBehaviour
{
    Pai p = new Pai();

    void Start()
    {
        p.Idade = 6;
        print(p.Idade);
    }

    class Pai : MonoBehaviour
    {
        private int idade = 10;
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value <= 5)
                {
                    idade = value;
                }
                else
                {
                    print("ERRO, valor maior que 5");
                }
            }
        }
    }
}
