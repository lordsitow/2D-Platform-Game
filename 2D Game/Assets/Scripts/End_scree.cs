using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class End_scree : MonoBehaviour
{
    public Text Total_coins;
    public Text coins_1lvl;
    public Text coins_2lvl;
    public Text coins_3lvl;

    public void Start()
    {
        Total_coins.text = "Total Gathered Coins: " + PlayerPrefs.GetInt("total_coins");
        coins_1lvl.text = "Coins from 1 level: " + PlayerPrefs.GetInt("coins_1lvl");
        coins_2lvl.text = "Coins from 2 level: " + PlayerPrefs.GetInt("coins_2lvl");
        coins_3lvl.text = "Coins from 3 level: " + PlayerPrefs.GetInt("coins_3lvl");
    }

    public void Update()
    {
        Total_coins.text = "Total Gathered Coins: " + PlayerPrefs.GetInt("total_coins");
        coins_1lvl.text = "Coins from 1 level: " + PlayerPrefs.GetInt("coins_1lvl");
        coins_2lvl.text = "Coins from 2 level: " + PlayerPrefs.GetInt("coins_2lvl");
        coins_3lvl.text = "Coins from 3 level: " + PlayerPrefs.GetInt("coins_3lvl");
    }
    public void Continue()
    {
        SceneManager.LoadScene(8);
    }

    public void Load_main_menu()
    {
        SceneManager.LoadScene(0);
    }
}
