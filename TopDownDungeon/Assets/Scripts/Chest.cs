using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        Debug.Log("Grand Peso");    //print in the console if the player has collide with the chest
    }
}
