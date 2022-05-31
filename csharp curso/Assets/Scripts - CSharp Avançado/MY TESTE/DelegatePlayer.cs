using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatePlayer : MonoBehaviour
{
    public delegate void MyDelegatePlayer();
    public static MyDelegatePlayer delegatePlayer;
}
