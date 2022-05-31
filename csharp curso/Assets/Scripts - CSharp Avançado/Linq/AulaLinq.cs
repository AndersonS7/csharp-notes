using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Classifica��o, pesquisa e filtragem de elementos
/// </summary>
public class AulaLinq : MonoBehaviour
{
    public class Enemy
    {
        public enum type
        {
            warrior,
            goblin,
            mage
        }

        public type enemyType;
        public bool alive;
        public float health;
        public string enemyName;
        public float speed;
    }

    public List<Enemy> allEnemies;

    public void SetWarriorStats()
    {
        //for (int i = 0; i < allEnemies.Count; i++)
        //{
        //    if(allEnemies[i].alive && allEnemies[i].enemyType.ToString() == "warrior")
        //    {
        //        allEnemies[i].speed += 10f;
        //    }
        //}

        foreach (var enemy in allEnemies)
        {
            if (enemy.alive && enemy.enemyType.ToString() == "warrior")
            {
                enemy.speed += 10f;
            }
        }
    }

    //retorna uma lista de inimigos vivos do tipo "warrior"
    public void SetWarriorStatsWithLinq()
    {
        Enemy[] warriors = allEnemies.Where(e => e.alive && e.enemyType.ToString() == "warrior").ToArray();

        foreach (var w in warriors)
            w.speed += 10f;
    }



    //retorna o primeiro inimigo warrior na lista que esteja vivo
    public void GetFirstWarrior()
    {
        Enemy warrior = allEnemies.FirstOrDefault(e => e.alive&& e.enemyType.ToString() == "warrior");
    }

    //retorna o �ltimo inimigo warrior na lista que esteja vivo
    public void GetLastWarrior()
    {
        Enemy warrior = allEnemies.LastOrDefault(e => e.alive && e.enemyType.ToString() == "warrior");
    }

    //retorna inimigos vivos e com maior vida
    public void GetByOrder()
    {
        var enemies = allEnemies.OrderBy(e => e.alive).ThenBy(e => e.health);
    }

    //encontra os 4 inimigos com menos vida
    public void Take()
    {
        var enemies = allEnemies.OrderBy(e => e.health).Take(4);
    }

    //verifica se h� algum inimigo vivo
    public void Any()
    {
        bool enemyIsAlive = allEnemies.Any(e => e.health > 0 && e.alive == true);
    }

    //verifica se cont�m determinado objeto na lista
    public void Contains()
    {
        Enemy e = new Enemy();

        if(allEnemies.Contains(e))
        {
            //retorna true
        }
    }

    //encontra os 4 inimigos com menos vida por�m ignora os 2 primeiros
    public void Skip()
    {
        var enemy = allEnemies.OrderBy(e => e.health).Take(4).Skip(2);
    }

}
