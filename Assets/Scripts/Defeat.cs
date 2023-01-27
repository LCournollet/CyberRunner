using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defeat : MonoBehaviour
{
<<<<<<< Updated upstream
    public void RestartGame()
    {
        Debug.Log("Restarting game...");
        SceneManager.LoadScene(0);
    }

=======
    // Start is called before the first frame update

    public void RestartGame()
    {
        Debug.Log("Restarting...");
        SceneManager.LoadScene(0);
    }

    // Update is called once per frame
>>>>>>> Stashed changes
    public void QuitGame()
    {
        Debug.Log("Exiting game...");
        Application.Quit();
    }
}
