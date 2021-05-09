using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu_func : MonoBehaviour
{
    public void gameStart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void gameExit(){
        Debug.Log("exit");
        Application.Quit();
    }
}
