using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="MyTeste", menuName = "Invetory/ MyTeste")]
public class MyTeste : ScriptableObject
{
    [SerializeField] private Vector3 currentPos;
    [SerializeField] private int gold;
    [SerializeField] private float damage;
    [SerializeField] private List<GameObject> invetory;

    //Pode ser usado para salvar qualquer tipo de dado.
}

/*
 * O SCRIPTABLEOBJECT SERVE PARA ARMAZENAR DADOS DO JOGO DE FORMA MAIS SIMPLES
 * SEM A NECESSIDADE DE USAR O PLAYER PREFS OU CONVERSÕES BINÁRIAS.
 */