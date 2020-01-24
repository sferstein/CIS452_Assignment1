using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
* Sam Ferstein
* Interfaces.cs
* Assignment 1
* Code for the interfaces for both the puncher and the kicker enemy.
*/

public interface IMissPunch
{
    // Puncher enemy misses a punch
    void missPunch();
}

public interface IThrowPunch
{
    // Puncher enemy throws a punch
    void throwPunch();
}

public interface IMissKick
{
    // Kicker enemy misses a kick
    void missKick();
}

public interface IThrowKick
{
    // Kicker enemy throws a kick
    void throwKick();
}
