using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Invetory/Player Stats")]
public class PlayerStates : ScriptableObject
{
    [SerializeField] private int goldAmount;
    [SerializeField] private float health;

    [SerializeField] private List<ItemObject> inventory = new List<ItemObject>();
}
