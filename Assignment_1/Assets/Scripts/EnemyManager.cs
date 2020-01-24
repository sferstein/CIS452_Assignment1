using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Sam Ferstein
* EnemyManager.cs
* Assignment 1
* Manages the enemies and will activate the methods depending on what key is pressed.
*/

public class EnemyManager : MonoBehaviour
{
    public Enemy punchEnemy;
    public Enemy kickEnemy;
    public Enemy bossEnemy;

    public List<Enemy> enemyList = new List<Enemy>();
    public List<IDamagePlayer> damageList = new List<IDamagePlayer>();

    // Start is called before the first frame update
    void Start()
    {
        punchEnemy = new Puncher();
        punchEnemy.Attack();
        kickEnemy = new Kicker();
        kickEnemy.Attack();
        bossEnemy = new Boss();
        bossEnemy.Attack();

        for (int i = 0; i < 2; i++)
        {
            enemyList.Add(new Puncher());
            enemyList.Add(new Kicker());
            enemyList.Add(new Boss());
        }

        for (int i = 0; i < 1; i++)
        {
            damageList.Add(new Puncher());
            damageList.Add(new Kicker());
            damageList.Add(new Boss());
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Enemy enemy in enemyList)
            {
                enemy.Attack();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (IDamagePlayer damage in damageList)
            {
                damage.HurtPlayer();
            }
        }
    }
}
