using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Between_levels : MonoBehaviour
{
    public Text Coins;
    public Text Time;
    public Text Score;

    public void Start()
    {
        Coins.text = "Coins: ";
        Time.text = "Time: ";
        Score.text = "Total Score: ";
    }

    public void Update()
    {
        Coins.text = "Coins: " + PlayerPrefs.GetInt("colected_coins").ToString();
        Time.text = "Time: ";
        Score.text = "Total Score: " + PlayerPrefs.GetInt("colected_coins").ToString();
    }

    public void RepeatLvl()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("last_scene"));
    }

    public void NextLvl()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("last_scene") + 1);
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
