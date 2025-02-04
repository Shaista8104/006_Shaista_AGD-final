using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Correct way to get the active scene and load the next one
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

