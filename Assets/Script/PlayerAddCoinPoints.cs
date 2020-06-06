using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAddCoinPoints : MonoBehaviour
{

    // Use this for initialization

    public Text coinText;

    int coins = 0;

    void Start()
    {
        coinText.text = "x" + coins;
    }

    public void AddCoins()
    {

        coins++;

        coinText.text = "x" + coins;


        //print(coins);
        
    }
}
