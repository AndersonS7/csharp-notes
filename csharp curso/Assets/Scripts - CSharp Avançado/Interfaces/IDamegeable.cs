using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// É um conjunto de métodos, propriedades que uma classe destino deve implementar
/// É um tipo declasse que contém apenas assinaturas de métodos e propriedades
/// Ajuda a organizar o código, permitindo a criação de código mais flexível
/// Para implementar, chama-se a interface após o : da classe. Ex: public class Player : IDamegeable
/// Padrão de nomenclatura: inicia-se o nome com I
/// </summary>

public interface IDamegeable
{
    int currentHealth { get; }
    void ApplyDamage(int damage);
}

public class MyClass : MonoBehaviour, IDamegeable
{
    public int currentHealth { get; set; }

    public void ApplyDamage(int damage)
    {
        //aplica o dano
    }
}
