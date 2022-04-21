using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : Collidable
{
    public string[] scenesNames;


    protected override void OnCollide(Collider2D coll)
    {
        if (coll.name == "Player")
        {
            // call the save state 
            GameManager.instance.SaveState();

            // Tele port the player

            // this line create a new scene by itself and it gonna pick between 0 and the length of the scene array
            string scenesName = scenesNames[Random.Range(0, scenesNames.Length)];

            // load scene
            UnityEngine.SceneManagement.SceneManager.LoadScene(scenesName);
        }
    }
}
