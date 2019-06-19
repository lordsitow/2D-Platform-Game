using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static colect_coin;

public class colect_treasure : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Treasure"))
        {
            coins = coins + 125;
            collision.gameObject.SetActive(false);
        }
    }
    
}
