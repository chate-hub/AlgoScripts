using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        CoinsCounter coins = other.GetComponent<CoinsCounter>();

        //The number of coins is updated
        coins.CollectCoins();

        //The coin that was collected is destroyed
        Destroy(gameObject);
    }
}

