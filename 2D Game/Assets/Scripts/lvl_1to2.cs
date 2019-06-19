using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static colect_coin;
using static colect_keys;


public class lvl_1to2 : MonoBehaviour
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
        
        if (player.transform.position.x > 133 && keys == 4)
        {
            PlayerPrefs.SetInt("colected_coins", coins);
            PlayerPrefs.SetInt("coins_1lvl", coins);
            PlayerPrefs.SetInt("total_coins", coins);
            PlayerPrefs.SetInt("last_scene", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(6);
        }
        if (player.transform.position.y < -6.5)
        {
            PlayerPrefs.SetInt("last_scene", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(4);
        }
    }
}
