using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static colect_coin;
using static colect_keys;

public class display_score : MonoBehaviour
{
    public Text countText;
    // Start is called before the first frame update
    void Start()
    {
        countText.text = "Coins: " + coins.ToString() + "               Keys: " + keys.ToString()+"/4";
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = "Coins: " + coins.ToString() + "               Keys: " + keys.ToString()+"/4";
    }
}
