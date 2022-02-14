using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    //some logic
    protected bool collected;

    //if something collide with object and its name is "Player", call the OnCollect() method
    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            OnCollect();
        }
    }

    //set collected property to true
    protected virtual void OnCollect()
    {
        collected = true;
    }
}
