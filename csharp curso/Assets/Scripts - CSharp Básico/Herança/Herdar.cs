using UnityEngine;

public class Herdar : MonoBehaviour
{
    Pai p;
    Filho f;

    void Start()
    {
        p = new Pai();
        f = new Filho();

        print(p.idade);
        p.Ataque();
        f.pegaIdade();

    }

    class Pai
    {
        public int idade = 40;

        public void Ataque()
        {
            print("Atacando...");
        }
    }

    class Filho : Pai
    {
        public void pegaIdade()
        {
            print(base.idade); // o base só vai funcionar se o filho herdar de pais pois o atributo usado é do pai
        }
    }
}

