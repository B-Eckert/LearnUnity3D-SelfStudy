using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameAlive = true;
    public void GameEnd(){
        if(gameAlive == true)
        {
            gameAlive = false;
            Debug.Log("GAME OVER");
            Invoke("Restart", 2);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameAlive = true;
    }
}
