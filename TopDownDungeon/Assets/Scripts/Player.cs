using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Vector3 moveDelta;

    // Start is called before the first frame update
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();    


    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //get input from user
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //reset moveDelta
        moveDelta = new Vector3(x, y, 0);

        //swap sprite direction, wether you move left or right
        if (moveDelta.x > 0)
            transform.localScale = Vector3.one; //player sprite swap to the right
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);   //player sprite swap to the left

        //make player move
        transform.Translate(moveDelta * Time.deltaTime);    //player can move left, right, up, down with this code

        

        
    }
}
