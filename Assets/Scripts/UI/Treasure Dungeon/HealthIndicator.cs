using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthIndicator : MonoBehaviour
{
    public TextMeshPro playerHealth;
    public PlayerStats playerStats;

    void Start()
    {
        if (playerStats == null)
        {

            playerStats = FindAnyObjectByType<PlayerStats>();
        }
    }

    public void Update()
    {
        
        playerHealth.text = "HP = " + playerStats.playerHealth;
    }
}
