using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake() 
    {
        // instance have to equal to the state when we start the game
        instance = this;

        // add an event after the scene has loaded, this case is save state
        // also SceneManager looks for every function in SaveState
        SceneManager.sceneLoaded += LoadState;

        DontDestroyOnLoad(gameObject);

    }

    //Resources
    public List<Sprite> playerSprites;
    public List<Sprite> weaponSprites;
    public List<int> weaponPrices;
    public List<int> xpTable;

    // References
    public Player player;
    // public weapon weapon ...

    // Logic
    public int pesos;
    public int experience;

    // save and load the game
    public void SaveState()
    {
        Debug.Log("SaveState");
    }

    public void LoadState(Scene s, LoadSceneMode mode)
    {
        
        Debug.Log("LoadState");
    }
}
