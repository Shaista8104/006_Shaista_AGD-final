using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMeu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        // Correct way to get the active scene and load the next one
        SceneManager.LoadScene("Task1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
