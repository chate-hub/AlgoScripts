using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public CoinsCounter coinsCount;
    public Health health;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;

    void Update()
    {
        // Updating the text with the number of coins
        coinsCounterText.text = coinsCount.coins.ToString();
        // Updating the player's health value
        healthSlider.maxValue = health.maxHealth;
        healthSlider.value = health.currenthealth;
    }
}