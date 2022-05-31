using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Classe abstrata sempre � uma superclasse
/// For�a a implementa��o de seus m�todos na classe herdada
/// Geralmente possui m�todos abstratos
/// </summary>
/// 
public abstract class NPC : MonoBehaviour
{
    protected string NPCName;
    protected float speed;
    protected bool isWalking;

    public abstract void Walk();
    public abstract void Speech();
}
