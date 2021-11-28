using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))] // automatically add a collider 2D to your object
public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter2D;
    private BoxCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10]; // contain the data of what exactly did you hit frame
    
    protected virtual void Start() 
    {
        boxCollider = GetComponent<BoxCollider2D>(); // whatever object collidable script is on, it requires collider 2D

    }

    protected virtual void Update() 
    {
        // Collision works
        boxCollider.OverlapCollider(filter2D, hits);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {
                continue;
            }

            OnCollide(hits[i]);

            // the array is not cleaned up, so we do it ourself
            hits[i] = null;
        }
    }

    //using inheritence
    protected virtual void OnCollide(Collider2D coll)
    {
        Debug.Log(coll.name);
    }

}
