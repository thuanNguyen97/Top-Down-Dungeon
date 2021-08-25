using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;


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
        {
            transform.localScale = Vector3.one; //player sprite swap to the right
        }      
        else if (moveDelta.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);   //player sprite swap to the left
        }

        //this line is to detect if 2 box was collider together, make sure we can move in this direction, by casting a box there first, if the box returns null, we are free to move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));

        if(hit.collider == null)
        {
            //make player move
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);    //player can move left, right, up, down with this code, this is for y axis
        }

        //this line is to detect if 2 box was collider together, make sure we can move in this direction, by casting a box there first, if the box returns null, we are free to move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));

        if(hit.collider == null)
        {
            //make player move
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);    //player can move left, right, up, down with this code, this is for x axis
        }


        

        

        
    }
}
