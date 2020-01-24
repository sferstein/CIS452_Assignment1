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

public class Puncher : Enemy, IMissPunch, IThrowPunch
{
    private int damageOut = 5;

    public override void Attack()
    {
        Debug.Log("The puncher attacks.");
    }

    public void throwPunch()
    {
        Debug.Log("The puncher throws a punch for " + damageOut + " damage.");
    }

    public void missPunch()
    {
        Debug.Log("The puncher has missed a punch.");
    }
}

public class Kicker : Enemy, IMissKick, IThrowKick
{
    private int damageOut = 12;

    public override void Attack()
    {
        Debug.Log("The kicker attacks.");
    }

    public void throwKick()
    {
        Debug.Log("The kicker throws a kick for " + damageOut + " damage.");
    }

    public void missKick()
    {
        Debug.Log("The kicker has missed a kick.");
    }
}

public class Boss : Enemy, IThrowPunch, IThrowKick
{
    private int damageOut = Random.Range(1, 20);

    public override void Attack()
    {
        Debug.Log("The boss attacks.");
    }

    public void throwKick()
    {
        Debug.Log("The boss throws a kick for " + damageOut + " damage.");
    }

    public void throwPunch()
    {
        Debug.Log("The boss throws a punch for " + damageOut + " damage.");
    }
}