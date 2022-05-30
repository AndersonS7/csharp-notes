using UnityEngine;

public class Exemplo : MonoBehaviour
{
    pai p;
    filho f;

    void Start()
    {
        f = new filho();

        f.pegaIdade();
    }

    class pai : MonoBehaviour
    {
        public int idade = 30;

        //public pai(int idade)
        //{
        //    this.idade = idade; // Não muito usual (maneira mais correta Idade = idade)
        //}
    }

    class filho : pai
    {
        public void pegaIdade()
        {
            print(base.idade);
        }
    }
}
/*
    BASE: SERVE PARA ACESSAR OS LINBOS DA CLASS BASE DE DENTRO DE UMA CLASS DERIVADA
    THIS: REFERENCIA O PRÓPRIO OBJETO
 */
