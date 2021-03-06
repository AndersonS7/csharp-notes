using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Usado quando o c?digo tende a se repetir em v?ias outras classes, para n?o precisar sair copiando e colando c?digo
/// ? um conjunto de m?todos, propriedades que uma classe destino deve implementar
/// ? um tipo declasse que cont?m apenas assinaturas de m?todos e propriedades
/// Ajuda a organizar o c?digo, permitindo a cria??o de c?digo mais flex?vel
/// Para implementar, chama-se a interface ap?s o : da classe. Ex: public class Player : IDamegeable
/// Padr?o de nomenclatura: inicia-se o nome com I
/// </summary>

public interface IDamegeable
{
    int currentHealth { get; }
    void ApplyDamage(int damage);
}

//classe de exemplo
//public class MyClass : MonoBehaviour, IDamegeable
//{
//    public int currentHealth { get; set; }

//    public void ApplyDamage(int damage)
//    {
//        //aplica o dano
//    }
//}
