using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Sam Ferstein
* Enemy.cs
* Assignment 1
* The enemy script that holds the abstract class for both enemies in the game,
* as well as the concrete classes for each enemy that outputs the console commands.
*/

public abstract class Enemy
{
    public abstract void Attack();
}

public class Puncher : Enemy, IDie, IDamagePlayer
{
    private int damageOut = 5;

    public override void Attack()
    {
        Debug.Log("The puncher attacks.");
    }

    public void HurtPlayer()
    {
        Debug.Log("The puncher throws a punch for " + damageOut + " damage.");
    }

    public void Die()
    {
        Debug.Log("The puncher has died.");
    }
}

public class Kicker : Enemy, IDie, IDamagePlayer
{
    private int damageOut = 12;

    public override void Attack()
    {
        Debug.Log("The kicker attacks.");
    }

    public void HurtPlayer()
    {
        Debug.Log("The kicker throws a kick for " + damageOut + " damage.");
    }

    public void Die()
    {
        Debug.Log("The kicker has died.");
    }
}

public class Boss : Enemy, IDie, IDamagePlayer
{
    private int damageOut = Random.Range(1, 20);

    public override void Attack()
    {
        Debug.Log("The boss attacks.");
    }

    public void HurtPlayer()
    {
        Debug.Log("The boss attacks the player for " + damageOut + " damage.");
    }

    public void Die()
    {
        Debug.Log("The boss has died.");
    }
}