using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defeat : MonoBehaviour
{
    public void RestartGame()
    {
        Debug.Log("Restarting game...");
        SceneManager.LoadScene(0);
    }

    public void QuitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
