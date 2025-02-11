using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static int numberOfCoins;
    public TMP_Text coinsText;

    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        coinsText.text = "Coins: " + numberOfCoins;
    }
}
