using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colect_keys : MonoBehaviour
{
    static public int keys;
    public int keys_count;
    // Start is called before the first frame update
    void Start()
    {
        keys = 0;
        keys_count = keys;
    }

    // Update is called once per frame

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            keys++;
            keys_count = keys;
            collision.gameObject.SetActive(false);
        }
    }
}

