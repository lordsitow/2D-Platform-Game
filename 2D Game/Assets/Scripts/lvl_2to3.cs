using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static colect_coin;
using static colect_keys;
public class lvl_2to3 : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.x > 302 && keys == 4)
        {
            PlayerPrefs.SetInt("colected_coins", coins);
            PlayerPrefs.SetInt("coins_2lvl", coins);
            PlayerPrefs.SetInt("total_coins",PlayerPrefs.GetInt("total_coins") + coins);
            PlayerPrefs.SetInt("last_scene", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(6);
        }
        if (player.transform.position.y < -31)
        {
            PlayerPrefs.SetInt("last_scene",SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(4);
        }
    }
}
