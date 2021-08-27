using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt;    //the player we want to look at
    public float boundX;    //how far the player go before the camera start following him
    public float boundY;

    // This method is call after Update() and even FixUpdate()
    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;  //this variable represet the difference between this frame and the next frame

        //check if the player out of the bounds on X axis
        float deltaX = lookAt.transform.position.x - transform.position.x;

        if (deltaX > boundX || deltaX < -boundX)    //the player out of the bound on the left and right site
        {
            if (transform.position.x < lookAt.position.x)
            {
                delta.x = deltaX - boundX; 
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        //check if the player out of the bounds on Y axis
        float deltaY = lookAt.transform.position.y - transform.position.y;

        if (deltaY > boundY || deltaY < -boundY)    //the player out of the bound on the up and down site
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY; 
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }

        //move the camera
        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
