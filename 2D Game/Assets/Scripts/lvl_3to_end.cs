using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static colect_coin;
using static colect_keys;
public class lvl_3to_end : MonoBehaviour
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
        if (28 > player.transform.position.x && player.transform.position.x > 26 && player.transform.position.y < 16 && keys == 4)
        {
            PlayerPrefs.SetInt("coins_3lvl", coins);
            PlayerPrefs.SetInt("total_coins", PlayerPrefs.GetInt("total_coins") + coins);
            SceneManager.LoadScene(5);
        }
        if (player.transform.position.y < -9)
        {
            PlayerPrefs.SetInt("last_scene", SceneManager.GetActiveScene().buildIndex);
            SceneManager.LoadScene(4);
        }
    }
}
