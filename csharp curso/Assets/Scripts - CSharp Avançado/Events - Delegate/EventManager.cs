using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EventManager : MonoBehaviour
{
    private void OnEnable()
    {
        Enemy.onEnemyDie += ShowGameOver;
    }

    private void OnDisable()
    {
        Enemy.onEnemyDie -= ShowGameOver;
    }

    private void ShowGameOver()
    {
        Debug.Log("Game Over!!!");
    }
}
