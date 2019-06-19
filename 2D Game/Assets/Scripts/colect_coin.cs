using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colect_coin : MonoBehaviour
{
    static public int coins;
    

    public int coin_count;
    

    void Start()
    {
        coins = 0;

        coin_count = 0;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins++;
            coin_count = coins;
            collision.gameObject.SetActive(false);
        }
    }
}
