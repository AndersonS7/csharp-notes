using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private bool control;

    public void DisabledInput()
    {
        control = false;
    }
}
