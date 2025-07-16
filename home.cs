using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Home : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        // Load the game scene
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        // Quit the application
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
