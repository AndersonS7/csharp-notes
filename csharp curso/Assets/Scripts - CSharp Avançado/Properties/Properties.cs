using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    //controle
    private bool isDad;
    private bool isWalking;

    //atributos
    [SerializeField] private float speed;
    [SerializeField] private string playerName;

    //componentes
    [SerializeField] private Rigidbody2D rig;
    [SerializeField] private Animator anim;

    //get => fazer a leitura
    //set => modificar o valor
    public float health { get; private set; } //só pode ser modificada dentro dessa class e não fora dela

    //campos de suporte
    public float damage
    {
        get
        {
            return health - 10f;
        }
    }
}