using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Sam Ferstein
* Interfaces.cs
* Assignment 1
* Code for the interfaces for both the puncher and the kicker enemy.
*/

public interface IDie
{
    // Puncher enemy misses a punch
    void Die();
}

public interface IDamagePlayer
{
    // Puncher enemy throws a punch
    void HurtPlayer();
}
