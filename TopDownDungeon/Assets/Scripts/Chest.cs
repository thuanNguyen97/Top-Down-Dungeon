using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int pesoAmount = 5;

    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            
            GetComponent<SpriteRenderer>().sprite = emptyChest;     //change the chest sprite to empty chest sprite
            Debug.Log("Grant " + pesoAmount + " peso!");
        }
    }
}
