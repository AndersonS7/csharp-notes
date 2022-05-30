using UnityEngine;

public class Polim : MonoBehaviour
{
    Lobo lobo;
    Cachorro cachorro;

    void Start()
    {
        lobo = new Lobo();
        cachorro = new Cachorro();

        lobo.Comer();
        cachorro.Comer();
    }

    class Animal
    {
        public virtual void Comer() // para poder sobreescrever a o método
        {
            print("Animal comendo...");
        }
    }

    class Lobo : Animal
    {
        public override void Comer() // sobreescreve o método comer
        {
            print("Lobo comendo...");
        }
    }

    class Cachorro : Animal
    {
        public override void Comer()
        {
            print("Cachorro comendo...");
        }
    }
}
